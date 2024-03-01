using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreacionDeControles
{
    public partial class Form1 : Form
    {
        private List<Cliente> clientes;
        private int indiceCombobox;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //miControl.getTextBoxApellido().Text = "holaaaa";

            statusLabel.Text = "Bienvenido!!!";

            StreamReader lector = new StreamReader("C:\\Users\\espar\\source\\repos\\CreacionDeControles\\res\\Clientes.txt");

            string linea;

            linea=lector.ReadLine();

            clientes = new List<Cliente>();

            while(linea != null)
            {
                string[] a =linea.Split('#');

                Cliente cliente = new Cliente();

                if (a.Length == 3)
                {

                    cliente.setNombre(a[0]);
                    cliente.setApellido(a[1]);
                    cliente.setTelefono(a[2]);

                }
                else
                {

                    cliente.setNombre(a[0]);
                    cliente.setApellido(a[1]);
                    cliente.setTelefono(a[2]);
                    cliente.setComentario(a[3]);

                }
                
                

                clientes.Add(cliente);

                linea = lector.ReadLine();
            }



            //clientes.Sort((c1, c2) => c1.getNombre().CompareTo(c2.getNombre()));// expresion lambda para comparar por nombre, se puede usar public class Cliente : IComparable<Cliente> y implementando 
            //public int CompareTo(Cliente other){}....

            OrdenaListayAgregaAlComboBox(clientes);

           /* foreach (Cliente c in clientes)// agrego al comboBox ordenados
            {
                
                miControl.getComboBoxClientes().Items.Add(c.getNombre()+","+c.getApellido());
            }*/

        }
        // para llamar varias veces en el programa, si se introduce o se borran elementos de la lista
        internal void OrdenaListayAgregaAlComboBox(List<Cliente> lista)
        {
            miControl.getComboBoxClientes().Items.Clear();//limpia la lista del comboBox si no no se actualizan los nombres

            lista.Sort((c1, c2) => c1.getNombre().CompareTo(c2.getNombre()));//woow!! ordena por nombre cual equals(override)de clase fuese, xd.

            foreach (Cliente c in clientes)// agrego al comboBox ordenados
            {

                miControl.getComboBoxClientes().Items.Add(c.getNombre() + "," + c.getApellido());
            }


           
        }

        /// <summary>
        /// https://es.stackoverflow.com/questions/321738/c%C3%B3mo-crear-el-evento-al-dar-clic-en-una-de-las-opciones-del-contextmenustrip-en
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            /* ToolStrip toolStrip = (ToolStrip)sender;
             //ToolStripButton botonPulsado = (ToolStripButton)sender; error
             //ToolStripButton botonPulsado = (ToolStripButton)toolStrip; nada
             ToolStripButton botonPulsado = e.ClickedItem as ToolStripButton; si, pero no me gusta.

             if (botonPulsado.Name.Equals("tsButtonNuevo"))
             {
                 miControl.getTextBoxNombre().Text = "";
                 miControl.getTextBoxApellido().Text = "";
                 miControl.getTextBoxTelefono().Text = "";
                 miControl.getTextBoxComentario().Text = "";
             }
             else if(botonPulsado.Name.Equals("tsButtonGuardar"))
             {

             }
             else if (botonPulsado.Name.Equals("tsButtonBorrar"))
             {

             }*/

            switch (e.ClickedItem.Name)
            {
                case "tsButtonNuevo":
                    

                    if (miControl.getTextBoxNombre().Text.Equals("") ||
                        miControl.getTextBoxApellido().Text.Equals("") ||
                        miControl.getTextBoxTelefono().Text.Equals(""))
                    {
                        MessageBox.Show("Porfavor rellene todos los campos del clinete");
                    }
                    else
                    {
                        Cliente clienteNuevo = new Cliente();
                        clienteNuevo.setNombre(miControl.getTextBoxNombre().Text);
                        clienteNuevo.setApellido(miControl.getTextBoxApellido().Text);
                        clienteNuevo.setTelefono(miControl.getTextBoxTelefono().Text);
                        clienteNuevo.setComentario(miControl.getTextBoxComentario().Text);

                        clientes.Add(clienteNuevo);
                        OrdenaListayAgregaAlComboBox(clientes);

                        PonerEnBlancoCampos();

                        statusLabel.Text = "Clinete Agregado";
                    }
                    
                    break;
                case "tsButtonGuardar":

                    if (miControl.getTextBoxNombre().Text.Equals("") ||
                        miControl.getTextBoxApellido().Text.Equals("") ||
                        miControl.getTextBoxTelefono().Text.Equals(""))
                    {
                        MessageBox.Show("Porfavor rellene los campos del cliente");
                    }
                    else
                    {
                        clientes[indiceCombobox].setApellido(miControl.getTextBoxApellido().Text);
                        clientes[indiceCombobox].setNombre(miControl.getTextBoxNombre().Text);
                        clientes[indiceCombobox].setTelefono(miControl.getTextBoxTelefono().Text);
                        clientes[indiceCombobox].setComentario(miControl.getTextBoxComentario().Text);

                        OrdenaListayAgregaAlComboBox(clientes);//no va a ordenar pero si refrescará el combobox

                        PonerEnBlancoCampos();
                        statusLabel.Text = "Cliente Modificado";
                    }
                    break;

                case "tsButtonBorrar":
                    Boolean borrado = false;
                    if (miControl.getTextBoxNombre().Text.Equals(""))//comprobando si el campo nombre esta vacio
                    {
                        MessageBox.Show("No hay cliente que borrar");
                        break;
                    }

                    foreach (Cliente cliente in clientes)
                    {
                        if(miControl.getTextBoxNombre().Text.Equals(cliente.getNombre()))
                        {
                            clientes.Remove(cliente);
                            borrado = true;
                            break;//para evitar excepcion por modificar la lista en un bucle.
                        }
                        
                        
                    }

                    MessageBox.Show(borrado ? "Borrado" : "No existe el cliente");
                    OrdenaListayAgregaAlComboBox(clientes);
                    PonerEnBlancoCampos();
                    statusLabel.Text = "Cliente Borrado";
                    break;
                default:
                    break;
            }
        }

        public void PonerEnBlancoCampos()
        {

            miControl.getTextBoxNombre().Text = "";
            miControl.getTextBoxApellido().Text = "";
            miControl.getTextBoxTelefono().Text = "";
            miControl.getTextBoxComentario().Text = "";

           // miControl.getComboBoxClientes().SelectedIndex = -1; no lo pone en blanco 
           // miControl.getComboBoxClientes().Refresh();
        }

        //aqui lee todos los eventos dentro de mi control porsonalizado
        private void miControl_Load(object sender, EventArgs e)
        {
            miControl.getComboBoxClientes().SelectedIndexChanged += ComboboxSeleccionado;
        }


        //solo para el combobox escogido
        private void ComboboxSeleccionado(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            indiceCombobox = comboBox.SelectedIndex;

            Cliente clienteSeleccionado = clientes[indiceCombobox];//se recupera de la lista ordenada

            miControl.getTextBoxNombre().Text= clienteSeleccionado.getNombre();
            miControl.getTextBoxApellido().Text = clienteSeleccionado.getApellido();
            miControl.getTextBoxTelefono().Text = clienteSeleccionado.getTelefono();
            miControl.getTextBoxComentario().Text = clienteSeleccionado.getComentario();

            statusLabel.Text = "Cliente consultado";

        }
    }
}
