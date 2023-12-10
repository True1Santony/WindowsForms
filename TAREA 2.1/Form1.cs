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

            ///////////////////////////////////////////////
            IDbCommand cmd = ctn.CreateCommand();

            cmd.CommandText = "select * from categories";

            IDataReader lector = cmd.ExecuteReader();

            while (lector.Read())

            {

                //this.listBox1.Items.Add(lector.GetString(1));
                RadioButton radioButton = new RadioButton();
                radioButton.Text = lector.GetString(1);
                radioButton.Tag = lector.GetInt32(0);
                //radioButton.AutoSize = true;
                radioButton.Font = new Font(radioButton.Font.FontFamily, 10, FontStyle.Bold);
                radioButton.Location = new Point(20, y);
                y += 40;
                radioButton.Click += new System.EventHandler(this.SelecionaRadioButton);
                Controls.Add(radioButton);
            }

            lector.Close();

        }


        private void SelecionaRadioButton(object sender, EventArgs e)
        {
            o = sender;//para actualizar
            EventArgs a = e;//para actualizar
            lstbProductId.Items.Clear();
            lstbProductName.Items.Clear();
            lstbUnitPrice.Items.Clear();
            lstbUnitStock.Items.Clear();

            RadioButton radioButton = (RadioButton)sender;
            int pkParametro = (int)radioButton.Tag;//recupero primary key

            string campoParametro = radioButton.Text;//recupero el CategoryName

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

        private void lstb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lstbSeleccionado = (ListBox)sender;
            int index = lstbSeleccionado.SelectedIndex;

            /*lstbProductName.SetSelected(index, true);
            lstbUnitPrice.SetSelected(index, true);
            lstbUnitStock.SetSelected(index, true);
            lstbProductId.SetSelected(index, true);
            */
            
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
            /*lstbUnitPrice.SetSelected(index, true);
            lstbUnitStock.SetSelected(index, true);
            lstbProductId.SetSelected(index, true);
            */

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            OleDbCommand cmd;

            cmd = new OleDbCommand();

            cmd.Connection = ctn;

            cmd.CommandText = "UPDATE Products SET ProductName='"+txtbProductName.Text+"', UnitPrice="+int.Parse(txtbUnitPrice.Text)+", UnitsInStock="+int.Parse(txtbUnitStock.Text)+" WHERE ProductID="+int.Parse(txtbProductId.Text);

            MessageBox.Show(cmd.ExecuteNonQuery().ToString());

            SelecionaRadioButton(o, a);
            txtbProductId.Clear();
            txtbProductName.Clear();
            txtbUnitPrice.Clear();
            txtbUnitStock.Clear();

        }


        /*private void lstbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstbProductName.SelectedIndex;

            lstbProductId.SetSelected(index, true);
            lstbUnitPrice.SetSelected(index, true);
            lstbUnitStock.SetSelected(index, true);
           // lstbProductName.SelectedIndex = lstbProductId.SelectedIndex = lstbUnitPrice.SelectedIndex = lstbUnitStock.SelectedIndex;
        }

        private void lstbUnitPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstbUnitPrice.SelectedIndex;

            lstbProductName.SetSelected(index, true);
            lstbProductId.SetSelected(index, true);
            lstbUnitStock.SetSelected(index, true);
        }

        private void lstbUnitStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstbUnitStock.SelectedIndex;

            lstbProductName.SetSelected(index, true);
            lstbUnitPrice.SetSelected(index, true);
            lstbProductId.SetSelected(index, true);
        }*/
    }
}
