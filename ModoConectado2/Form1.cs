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

namespace ModoConectado2
{
    public partial class Form1 : Form
    {

        private OleDbConnection ctn;
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; "+ "Data Source=Z:\\DAM\\2 Desarrollo de interfaces\\TEMA 2\\2.2\\Emple.mdb";
            ctn.Open();

            //MessageBox.Show(ctn.State.ToString());

            IDbCommand cmd = ctn.CreateCommand();
            cmd.CommandText = "select * from DEPART;";

            IDataReader lector =cmd.ExecuteReader();

            while (lector.Read())
            {
                this.lstbDepartamento.Items.Add(lector[1]);
                this.lstbLocalizacion.Items.Add(lector[2]);
            }

        }

        private void lstbDepartamento_Click(object sender, EventArgs e)
        {

            lstbApellidos.Items.Clear();
            lstbComision.Items.Clear();
            lstbFechaAlta.Items.Clear();
            lstbOficio.Items.Clear();
            lstbSalario.Items.Clear();

            txtApellidos.Clear();
            txtComision.Clear();
            txtFechaAlta.Clear();
            txtOficio.Clear();
            txtSalario.Clear();

            ListBox lstbSeleccionado = (ListBox)sender;
            string departamento = lstbSeleccionado.SelectedItem.ToString();


            IDbCommand cmd = ctn.CreateCommand();
            cmd.CommandText = "select * from EMPLE where dept_no =(select DEPT_NO from DEPART where DNOMBRE='" + departamento + "')"; 

            IDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {

                lstbApellidos.Items.Add(lector[1]);
                lstbComision.Items.Add(lector[6]);
                DateTime fechaAlta = lector.GetDateTime(lector.GetOrdinal("Fecha_Alt"));
                lstbFechaAlta.Items.Add(fechaAlta.ToString("dd/MM/yyyy"));
                lstbOficio.Items.Add(lector[2]);
                lstbSalario.Items.Add(lector[5]);

            }
            index = 0;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            Button subeBaja = (Button)sender;
            string opcion =subeBaja.Name;
            int min = 0;
            int max = (lstbApellidos.Items.Count)-1;//indice valido

            if (opcion.Equals("btnSubir") && index>=min)
            {
                if (index > min)
                {
                    index--;
                }

                this.setTextBox(index);

                
            }
            else if (opcion.Equals("btnBajar") && index<=max)
            {
                if (index < max)
                {
                    index++;
                }
                this.setTextBox(index);

                
            }
        }

        private void setTextBox(int index)
        {
            try
            {
                txtApellidos.Text = lstbApellidos.Items[index].ToString();
                txtComision.Text = lstbComision.Items[index].ToString();
                txtFechaAlta.Text = lstbFechaAlta.Items[index].ToString();
                txtOficio.Text = lstbOficio.Items[index].ToString();
                txtSalario.Text = lstbSalario.Items[index].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error, causas:\n1. Escoja un Departamento antes de navegar por las opciones. \n2. El departamento está vacio.\n"+e.Message);
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ctn.Close();
            Environment.Exit(0);
        }
    }
}
