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

namespace Examen
{
    public partial class Form1 : Form
    {

        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapterTiposIncidencia;
        private DataSet dataSet;
        private int y = 60;
        private Object o;
        EventArgs a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=C:\\temp\\Gestion Incidencias.mdb";
            connection.Open();

            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = connection;

            cmd.CommandText = "select * from TiposIncidencias";

            IDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                //se crean los darioButton por cada vuelta del while
                RadioButton radioButton = new RadioButton();
                radioButton.Text = lector.GetString(1);// campo 2 de la tabla, dataType Text
                radioButton.Tag = lector.GetInt32(0);// PrimaryKey campo 1 de la tabla dataType AutoInc
                                                     //radioButton.AutoSize = true;
                radioButton.Font = new Font(radioButton.Font.FontFamily, 5, FontStyle.Bold);//formato arraglar

                radioButton.Location = new Point(20, y);
                y += 40;
                radioButton.Click += new System.EventHandler(this.SelecionaRadioButton);
                Controls.Add(radioButton);
            }


            /* //agrego al data set la tabla de Tipos de incidencia
             cmd.CommandText = "select * from TiposIncidencias;";
             dataAdapterTiposIncidencia = new OleDbDataAdapter();
             OleDbCommandBuilder comBuilder = new OleDbCommandBuilder(dataAdapterTiposIncidencia);
             dataAdapterTiposIncidencia.SelectCommand = cmd;
             dataAdapterTiposIncidencia.FillSchema(dataSet, SchemaType.Mapped, "TiposIncidencias");
             dataAdapterTiposIncidencia.Fill(dataSet, "TiposIncidencias");

             //fin carga al data set
             //connection.Close(); cerrar cuando este ok


             //cargar los radio button

             DataTable tabla = dataSet.Tables["TiposIncidencias"];

             foreach(DataRow registro in tabla.Rows)
             {

                 RadioButton radioBtn = new RadioButton();

                 radioBtn.Text = registro["DescTipo"].ToString();

                //radioBtn.Tag = registro["IdTipo"];
                radioBtn.Font = new Font(radioBtn.Font.FontFamily, 7, FontStyle.Bold);
                 radioBtn.Location = new Point(20, y);

                 radioBtn.Click += new System.EventHandler(this.SelecionaRadioButton);

                 y += 30;

                 Controls.Add(radioBtn);
             }

         }

         private void SelecionaRadioButton(object sender, EventArgs e)
         {

         }*/
        }

        private void SelecionaRadioButton(object sender, EventArgs e)
        {
            o= sender;
            EventArgs a = e;

            lstbDescIncidencia.Items.Clear();
            lstbFechaInicio.Items.Clear();
            lstbGeneraAveria.Items.Clear();
            lstbIncidencia.Items.Clear();

            RadioButton radiobutton = (RadioButton)sender;
            int pkParametro = (int)radiobutton.Tag;

            string sql = "select * from Incidencias where TipoIncidencia=@Code";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            OleDbParameter idIncidencia = new OleDbParameter("@Code", pkParametro);
            idIncidencia.Direction = ParameterDirection.Input;

            cmd.Parameters.Add(idIncidencia);

            OleDbDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                lstbDescIncidencia.Items.Add(lector[1]);
                lstbFechaInicio.Items.Add(lector[3]);
                lstbGeneraAveria.Items.Add(lector[2]);
                lstbIncidencia.Items.Add(lector[0]);
            }
        }

        private void lstbIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListBox lstbSeleccionado = (ListBox)sender;
            int index = lstbSeleccionado.SelectedIndex;

            if (index != lstbDescIncidencia.SelectedIndex)
            {
                lstbDescIncidencia.SetSelected(index, true);
            }
            if (index != lstbFechaInicio.SelectedIndex)
            {
                lstbFechaInicio.SetSelected(index, true);
            }
            if (index != lstbGeneraAveria.SelectedIndex)
            {
                lstbGeneraAveria.SetSelected(index, true);
            }
            if (index != lstbIncidencia.SelectedIndex)
            {
                lstbIncidencia.SetSelected(index, true);
            }

            txtbDescIncidencia.Text = lstbDescIncidencia.SelectedItem.ToString();
            txtbFechaInicio.Text = lstbFechaInicio.SelectedItem.ToString();
            txtbGeneraAveria.Text = lstbGeneraAveria.SelectedItem.ToString();
            txtbIncidencia.Text = lstbIncidencia.SelectedItem.ToString();

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

            if (!(txtbIncidencia.Text.Equals("")))
            {

                IDbCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select MAX(IdIncidencia) from Incidencias";

                int inIncidenciaNuevo = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                cmd.CommandText = "INSERT INTO Incidencias(IdIncidencia, DescIncidencia, GeneraAveria, FechaInicio) values (????);";

                cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = inIncidenciaNuevo });
                cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar) { Value = txtbDescIncidencia.Text });
                cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = int.Parse(txtbGeneraAveria.Text) });
                cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Date) { Value = DateTime.Parse(txtbFechaInicio.Text) });


                cmd.ExecuteNonQuery();

                SelecionaRadioButton(o, a);
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (!(txtbIncidencia.Text.Equals("")))
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "DELETE from Incidencias where IdIncidencia=?";
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = int.Parse(txtbIncidencia.Text) });
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Borrado");
                    
                }
                catch (Exception ex) { MessageBox.Show(ex.Message + "\nEscoja un empleado a borrar"); }
            }
            else
            {
                MessageBox.Show("Escoja un empleado a borrar.");
            }

        }
    }
}

