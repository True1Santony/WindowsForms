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

namespace TEMA_2._1
{
    public partial class Form1 : Form
    {
        // Declaración de la conexión a la base de datos Northwind como atributo

        private OleDbConnection ctn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        // Creación de la conexión

        ctn = new OleDbConnection();

        ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=Z:\\DAM\\2 Desarrollo de interfaces\\TEMA 2\\2.1\\nwind.mdb";

        // Apertura de la conexión

        ctn.Open();

            // Comprobación del estado de la conexión

            MessageBox.Show(ctn.State.ToString());


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            IDbCommand cmd = ctn.CreateCommand();

            cmd.CommandText = "select * from products";

            IDataReader lector = cmd.ExecuteReader();

            while (lector.Read())

            {

                this.listBox1.Items.Add(lector.GetString(1));

            }

            lector.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctn.Close();
        }

       

        private void btn2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = ctn;

            cmd.CommandText = " select * from categories";

            OleDbDataReader lector = cmd.ExecuteReader();

            while (lector.Read())

            {

                this.listBox1.Items.Add(lector["CategoryName"]);

            }

            lector.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string sql = "select * from orders where customerId='" + textBox1.Text + "'";

            OleDbCommand cmd;

            cmd = new OleDbCommand();

            cmd.Connection = ctn;

            cmd.CommandText = sql;

            OleDbDataReader lector = cmd.ExecuteReader();

            while (lector.Read())

            {

                this.listBox1.Items.Add((int)lector[0]);

            }

            lector.Close();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string sql = "select * from orders where customerId=@Code";

            OleDbCommand cmd = new OleDbCommand();//admite como primer parametro un string sql, el segundo la conexion.

            cmd.Connection = ctn;

            cmd.CommandText = sql;

            OleDbParameter paramCustomerId = new OleDbParameter("@Code", textBox1.Text);

            paramCustomerId.Direction = ParameterDirection.Input;

            cmd.Parameters.Add(paramCustomerId);

            OleDbDataReader lector = cmd.ExecuteReader();

            while (lector.Read())

            {

                this.listBox1.Items.Add(lector[0]);

            }

            lector.Close();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = ctn;

            cmd.CommandText = "select count(orderid) from orders where customerid ='FRANK'";


            MessageBox.Show(cmd.ExecuteScalar().ToString());


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd;

            cmd = new OleDbCommand();

            cmd.Connection = ctn;

            cmd.CommandText = "Insert into shippers (companyname,phone) values('DHL','02 40 41 42 43')";

            MessageBox.Show(cmd.ExecuteNonQuery().ToString());
        }
    }
}
