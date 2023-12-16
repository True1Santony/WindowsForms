using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA_2._1
{
    public partial class Form1 : Form
    {

        private OleDbConnection ctn;
        int y = 60;
        Object o;
        EventArgs a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctn = new OleDbConnection();

            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=Z:\\DAM\\2 Desarrollo de interfaces\\TEMA 2\\2.1\\nwind.mdb";

            // Apertura de la conexión

            ctn.Open();

            // Comprobación del estado de la conexión

            MessageBox.Show(ctn.State.ToString());

            //interfaz comandos sql
            IDbCommand cmd = ctn.CreateCommand();

            cmd.CommandText = "select * from categories";
            
            //interfaz lectura por tupla
            IDataReader lector = cmd.ExecuteReader();

            while (lector.Read())

            {

                //se crean los darioButton por cada vuelta del while
                RadioButton radioButton = new RadioButton();
                radioButton.Text = lector.GetString(1);// campo 2 de la tabla, dataType Text  
                radioButton.Tag = lector.GetInt32(0);// PrimaryKey campo 1 de la tabla dataType AutoInc
                //radioButton.AutoSize = true;
                radioButton.Font = new Font(radioButton.Font.FontFamily, 10, FontStyle.Bold);//formato
                radioButton.Location = new Point(20, y);
                y += 40;
                radioButton.Click += new System.EventHandler(this.SelecionaRadioButton);
                Controls.Add(radioButton);
            }

            lector.Close();

        }


        /// <summary>
        /// Metod que se asocia a cada Radio button creados en tiempo de ejecucion
        /// Limpia los listBox, creao un objeto de OleDbCommand y hace un select en Productos
        /// en función de CategoryId 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelecionaRadioButton(object sender, EventArgs e)
        {
            o = sender;//para actualizar en btnActualizar_Click()
            EventArgs a = e;//para actualizar en btnActualizar_Click()
            lstbProductId.Items.Clear();
            lstbProductName.Items.Clear();
            lstbUnitPrice.Items.Clear();
            lstbUnitStock.Items.Clear();

            RadioButton radioButton = (RadioButton)sender;
            int pkParametro = (int)radioButton.Tag;//recupero primary key de categories

            // no se usa string campoParametro = radioButton.Text;//recupero el CategoryName

            string sql = "select * from Products where categoryId=@Code";

            OleDbCommand cmd = new OleDbCommand(sql,ctn);//.commandText, .connection

            OleDbParameter paramCustomerId = new OleDbParameter("@Code", pkParametro);

            paramCustomerId.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(paramCustomerId);

            OleDbDataReader lector = cmd.ExecuteReader();

            while (lector.Read())

            {

                this.lstbProductId.Items.Add(lector[0]);
                this.lstbProductName.Items.Add(lector[1]);
                this.lstbUnitPrice.Items.Add(lector[5]);
                this.lstbUnitStock.Items.Add(lector[6]);

            }

            lector.Close();

        }

        /// <summary>
        /// Metodo seleccion de indice de los ListBox, agregado en diseño. Todos los ListBox tendrán misma longitud, se puede usar sin el problema
        /// de distintas longitudes. Evita las retro-llamadas entre los listBox con condiciones if. Establece en los campos TextBox
        /// la seleccion desde cualquier ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lstbSeleccionado = (ListBox)sender;
            int index = lstbSeleccionado.SelectedIndex;
            
            // Verificar si el índice es diferente antes de establecer la selección si no entra en bucle infinito y falla.
            if (index != lstbProductName.SelectedIndex)
            {
                lstbProductName.SetSelected(index, true);
            }

            if (index != lstbUnitPrice.SelectedIndex)
            {
                lstbUnitPrice.SetSelected(index, true);
            }

            if (index != lstbUnitStock.SelectedIndex)
            {
                lstbUnitStock.SetSelected(index, true);
            }

            if (index != lstbProductId.SelectedIndex)
            {
                lstbProductId.SetSelected(index, true);
            }

            txtbProductName.Text=lstbProductName.SelectedItem.ToString();
            txtbProductId.Text = lstbProductId.SelectedItem.ToString();
            txtbUnitPrice.Text = lstbUnitPrice.SelectedItem.ToString();
            txtbUnitStock.Text = lstbUnitStock.SelectedItem.ToString();
            

        }

        /// <summary>
        /// Actualiza siempre, si se pulsa en el boton de actualizar. En el programa double se reconoce con ","
        /// en SQL base de datos lo reconoce con "." asi que se sustituye la "," por "." para que los dos funcionen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {

            OleDbCommand cmd;

            cmd = new OleDbCommand();

            cmd.Connection = ctn;

            String reconvertido = txtbUnitPrice.Text.Replace(",", ".");

            try
            {
                double probarLoIntrodocido = double.Parse(txtbUnitPrice.Text);// solo para lanzar excepcion en caso de que se introduzca un valor invalido
                cmd.CommandText = "UPDATE Products SET ProductName='" + txtbProductName.Text + "', UnitPrice=" + reconvertido + ", UnitsInStock=" + int.Parse(txtbUnitStock.Text) + " WHERE ProductID=" + int.Parse(txtbProductId.Text);

                MessageBox.Show(cmd.ExecuteNonQuery().ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            finally
            {
                SelecionaRadioButton(o, a);
                txtbProductId.Clear();
                txtbProductName.Clear();
                txtbUnitPrice.Clear();
                txtbUnitStock.Clear();

                cmd.Dispose();
            }
             

            

        }

    }
}
