using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reloj
{
    public partial class Form1 : Form
    {

        private bool actualizarHoraPaisSeleccionado = false;
        private double diferenciaHoraria;

        public Form1()
        {
            InitializeComponent();
        }

        //si no hay seleccionado ningun pais no se muestra en el segundo txt nada
        //se pone a true cuando se selecciona un pais creado en la lista.
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");

            if (actualizarHoraPaisSeleccionado)
            {
                txtHoraPaisSeleccionado.Text = DateTime.Now.AddHours(diferenciaHoraria).ToString("HH:mm:ss");
            }
        }

        /// <summary>
        /// este controlador de eventos, al clicar en menu>añadir
        /// abrira una nueva ventana FrmPais y creará un nuevo elemento menu
        /// debajo del último elemento. Obtiene de FrmPais los parametros string
        /// nombre y double diferneciaHora. Este elemento creado se le asigna un 
        /// contolador de eventos CalcularHoraPais
        /// </summary>
        private void MnuPaisAnadir_Click(object sender, EventArgs e)
        {
            FrmPais f = new FrmPais();
            f.ShowDialog();

            ToolStripMenuItem elemento = new ToolStripMenuItem();
            elemento.Text = f.ObtenerTextoNombrePais();
            elemento.Tag = f.ObtenerIntDiferenciaHoraria();
            MnuPais.DropDownItems.Add(elemento);
            elemento.Click += new System.EventHandler(this.CalcularHoraPais);
        }

        /// <summary>
        /// Muestra el pais seleccionado, de los creados, en el menu y lo muestra en el label
        ///Contoene una variable de metodo para .AddHours(), que se recoge del sender(elemento creado)
        ///Es el controlador de eventos de los toolStripMenuItem creados por el usuario.
        /// </summary>
        private void CalcularHoraPais(object sender, EventArgs e)
        {
            lblPais.Text=((ToolStripMenuItem)sender).Text;
            diferenciaHoraria = Convert.ToDouble(((ToolStripMenuItem)sender).Tag);
            // txtHoraPaisSeleccionado.Text = DateTime.Now.AddHours(diferenciaHoraria).ToString("HH:mm:ss"); solo con esto es un string estatico, lo paso al manejador timer1_Tick
            actualizarHoraPaisSeleccionado = true;
        }

        /// <summary>
        /// Este metodo recorre los Item creados del MnuPais a partir del separador
        /// (posicion 3) y los almacena en un List.
        /// </summary>
        /// <param name="List string">guarda el listado de paises creados </param>
        /// <returns>listado de paises creados</returns>
        private List<string> ObtenerListaDePaises()
        {
            List<string> listaPaises = new List<string>();

            // Comenzar a agregar elementos después de la posición del separador
            for (int i = 3; i < MnuPais.DropDownItems.Count; i++) // El separador está en la posición 3
            {
                if (MnuPais.DropDownItems[i] is ToolStripMenuItem menuItem)
                {
                    listaPaises.Add(menuItem.Text);
                }
            }

            return listaPaises;
        }

        /// <summary>
        /// Controlador de eventos del menu>borrar crea una nueva instancia de BorrarPais
        /// 
        /// </summary>
        private void MnuPaisBorrar_Click(object sender, EventArgs e)
        {
            BorrarPais f = new BorrarPais(ObtenerListaDePaises());
            f.ShowDialog();
        }

        /// <summary>
        /// Metodo para borrar un pais, Borra elementos de MnuPais por su posicion
        /// Probar metodo estatico. para poder invocarlo desde la clase BorrarPais
        /// </summary>
        public void BorrarPais(int posicion)
        {
            MnuPais.DropDownItems.RemoveAt(posicion);
        }
    }
}
