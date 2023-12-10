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
    
    public partial class BorrarPais : Form
    {
        Form1 form1 = (Form1)Application.OpenForms["Form1"];//referencia al formulario principal para usar sus metodos sin instanciar un objeto de este.
        private List<string> paises;
        public BorrarPais(List<string> listaPaises)
        {
            InitializeComponent();
            paises = listaPaises;
            MostrarCheckBoxes();
        }

        private void MostrarCheckBoxes()
        {
            // Crear un CheckBox por cada país en la lista
            int y = 30; // Posición vertical inicial para los CheckBox
            foreach (string pais in paises)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = pais;
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(20, y);// para que no este pegado
                y += 30; // Incremento en la posición vertical para el próximo CheckBox
                Controls.Add(checkBox); // agrego el CheckBox al formulario
            }
            Button btnBorrar = new Button();
            btnBorrar.Text = "Borrar";
            btnBorrar.Location = new System.Drawing.Point(20, y);// siempre estara debajo tras pasar por el bucle foreach y valdrá 30 mas que el ultimo checkbox
            btnBorrar.Click += new System.EventHandler(this.BorrarCasillasSeleccionadas);
            Controls.Add(btnBorrar); // agrego el boton al formulario
        }
        private void BorrarCasillasSeleccionadas(object sender, EventArgs e)
        {
            // lista temporal para almacenar los CheckBoxes a borrar
            List<CheckBox> casillasABorrar = new List<CheckBox>();

            // Recorrer los controles y agregar los CheckBoxes seleccionados a la lista temporal
            int posicion=3;//es la posicion despues del espaciador.
            foreach (Control control in Controls)// recorre todos los controles
            {
                if (control is CheckBox checkBox && checkBox.Checked)//recorre solo los checkBox
                {
                    casillasABorrar.Add(checkBox);
                    form1.BorrarPais(posicion); //borra del Form1, en la posicion que este checkeado
                    
                }
                posicion++;
            }

            // Eliminar los CheckBoxes seleccionados del formulario y de la lista paises
            foreach (CheckBox checkBox in casillasABorrar)
            {
                Controls.Remove(checkBox); // Eliminar del formulario
                checkBox.Dispose(); // Liberar recursos asociados al CheckBox eliminado, para no consumir recursos.

                paises.Remove(checkBox.Text); // Eliminar de la lista paises
            }
            Close();
        }
    }
}
