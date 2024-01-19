using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ModoDesconectado
{
    public partial class Form1 : Form
    {

        private OleDbConnection ctn;
        private DataSet ds = new DataSet();
        private OleDbDataAdapter daCategories, daProducts;
        private int y = 60;//posicion inicial radiobutons

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=Z:\\DAM\\2 Desarrollo de interfaces\\TEMA 2\\2.1\\Nwind.mdb";
            ctn.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = ctn;

            // Llenar la tabla "categorias"
            cmd.CommandText = "select * from categories;";
            daCategories = new OleDbDataAdapter();
            OleDbCommandBuilder cbCategories = new OleDbCommandBuilder(daCategories);
            daCategories.SelectCommand = cmd;
            daCategories.FillSchema(ds, SchemaType.Mapped, "categorias");
            daCategories.Fill(ds, "categorias");

            // Llenar la tabla "productos"
            cmd.CommandText = "select * from Products;";
            daProducts = new OleDbDataAdapter();
            OleDbCommandBuilder cbProducts = new OleDbCommandBuilder(daProducts);
            daProducts.SelectCommand = cmd;
            daProducts.FillSchema(ds, SchemaType.Mapped, "productos");
            daProducts.Fill(ds, "productos");

            ctn.Close();

            // Recorrer la tabla
            DataTable tabla = ds.Tables["categorias"];

            foreach (DataRow registro in tabla.Rows)
            {
                RadioButton radButton = new RadioButton();
                radButton.Text = registro["CategoryName"].ToString();//nombre de las categorias
                radButton.Tag = registro["CategoryID"];//pk de la tabla
                radButton.Location = new Point(20, y);
                y += 40;
                radButton.Click += new System.EventHandler(this.SelecionaRadioButton);
                Controls.Add(radButton);
            }
        }

        private void SelecionaRadioButton(object sender, EventArgs e)
        {

            lstbProductId.Items.Clear();
            lstbProductName.Items.Clear();
            lstbUnitPrice.Items.Clear();
            lstbUnitStock.Items.Clear();

            RadioButton radButSelecion = (RadioButton)sender;
            int clave = (int)radButSelecion.Tag;

            DataTable tabla = ds.Tables["productos"];
            foreach (DataRow registro in tabla.Rows)

            {
                if ((int)registro["CategoryID"] == clave)
                {
                    this.lstbProductId.Items.Add(registro["ProductID"]);
                    this.lstbProductName.Items.Add(registro["ProductName"]);
                    this.lstbUnitPrice.Items.Add(registro["UnitPrice"]);
                    this.lstbUnitStock.Items.Add(registro["UnitsInStock"]);
                }

            }

        }

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

            txtbProductName.Text = lstbProductName.SelectedItem.ToString();
            txtbProductId.Text = lstbProductId.SelectedItem.ToString();
            txtbUnitPrice.Text = lstbUnitPrice.SelectedItem.ToString();
            txtbUnitStock.Text = lstbUnitStock.SelectedItem.ToString();


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int clave;
            int.TryParse(txtbProductId.Text, out clave);

            DataTable tabla = ds.Tables["productos"];
            foreach (DataRow registro in tabla.Rows)
            {
                if ((int)registro["ProductID"] == clave)
                {

                    registro.BeginEdit();
                    registro["ProductName"] = txtbProductName.Text.ToString();
                    registro["UnitPrice"] = txtbUnitPrice.Text.ToString();
                    registro["UnitsInStock"] = txtbUnitStock.Text.ToString();

                    registro.EndEdit();//solo va a haber uno.
                }
            }

            ctn.Open();
            daProducts.Update(ds, "productos");
            ds.AcceptChanges();
            ctn.Close();
        }
    }
}