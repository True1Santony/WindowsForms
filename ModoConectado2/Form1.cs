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
        private string sEscogido=null;
        
        private ListBox lstbSeleccionado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstbBuscarPor.Items.Add("Apellido");
            lstbBuscarPor.Items.Add("Oficio");
            lstbBuscarPor.Items.Add("Salario");
            lstbBuscarPor.Items.Add("Fecha_Alt");
            lstbBuscarPor.Items.Add("Comision");

            ctn = new OleDbConnection();
            

                ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=Z:\\DAM\\2 Desarrollo de interfaces\\TEMA 2\\2.2\\Emple.mdb";
                ctn.Open();

            //MessageBox.Show(ctn.State.ToString());

            IDbCommand cmd = ctn.CreateCommand();
                cmd.CommandText = "select * from DEPART;";

                IDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    lstbIDdepartamento.Items.Add(lector[0]);
                    lstbDepartamento.Items.Add(lector[1]);
                    lstbLocalizacion.Items.Add(lector[2]);

                }
            
            }

        private void lstbDepartamento_Click(object sender, EventArgs e)
        {
            ReseteaCampos();

            txtApellidos.Clear();
            txtComision.Clear();
            txtFechaAlta.Clear();
            txtOficio.Clear();
            txtSalario.Clear();
            txtOcultoID.Clear();
            //txtIDdepartamento.Clear();

            lstbSeleccionado = (ListBox)sender;
            string departamento = lstbSeleccionado.SelectedItem.ToString();



            IDbCommand cmd = ctn.CreateCommand();
            cmd.CommandText = "select * from EMPLE where dept_no =(select DEPT_NO from DEPART where DNOMBRE='" + departamento + "')"; 

            IDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                lstbOcultoID.Items.Add(lector[0]);
                lstbApellidos.Items.Add(lector[1]);
                lstbComision.Items.Add(lector[6]);
                DateTime fechaAlta = lector.GetDateTime(lector.GetOrdinal("Fecha_Alt"));
                lstbFechaAlta.Items.Add(fechaAlta.ToString("dd/MM/yyyy"));
                lstbOficio.Items.Add(lector[2]);
                lstbSalario.Items.Add(lector[5]);

            }
            index = 0;
            
        }

        /// <summary>
        /// Implementa la funcionalidad de los botones arriba y abajo para navegar por los 
        /// distintos empleados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                txtOcultoID.Text = lstbOcultoID.Items[index].ToString();
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

        private void lstbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ltbEscogido = (ListBox)sender;
            sEscogido = ltbEscogido.SelectedItem.ToString();

            txtbBuscar.Text = "";//resetea cada vez que se cambia de opcion

            /*IDbCommand cmd = ctn.CreateCommand();
            cmd.CommandText = "SELECT * FROM EMPLE WHERW ?=?";


            switch (sEscogido)
            {
                case "Apellidos":
                    break;
                case "Oficio":
                    break;
                case "Fecha Alta":
                    break;
                case "Salario":
                    break;
                case "Comisión":
                    break;
              
            }*/
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ReseteaCampos();

           string opcion=txtbBuscar.Text;
            if (!(txtbBuscar.Text.Equals("")) && sEscogido!=null )
            {

                IDbCommand cmd = ctn.CreateCommand();
  
                cmd.CommandText = "SELECT * FROM EMPLE WHERE " + sEscogido + " =? ;";

                cmd.Parameters.Add(new OleDbParameter("?", opcion));//si es un parametro vale, pero varios hay que usar @id`s



                try {
                    IDataReader lector = cmd.ExecuteReader();
                    while (lector.Read())
                    {
                        lstbOcultoID.Items.Add(lector[0]);
                        lstbApellidos.Items.Add(lector[1]);
                        lstbComision.Items.Add(lector[6]);
                        DateTime fechaAlta = lector.GetDateTime(lector.GetOrdinal("Fecha_Alt"));
                        lstbFechaAlta.Items.Add(fechaAlta.ToString("dd/MM/yyyy"));
                        lstbOficio.Items.Add(lector[2]);
                        lstbSalario.Items.Add(lector[5]);

                    }
                }catch (Exception ex){MessageBox.Show(ex.Message);}

            }
            else
            {

                MessageBox.Show("Introduzca el dato por el que filtrar la búsqueda y escoja una opcion de la lista.");
            }
            

            
        }

        private void ReseteaCampos()
        {

            lstbApellidos.Items.Clear();
            lstbComision.Items.Clear();
            lstbFechaAlta.Items.Clear();
            lstbOficio.Items.Clear();
            lstbSalario.Items.Clear();
            lstbOcultoID.Items.Clear();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(txtApellidos.Text.Equals("")))//se puede poner cualquier campo ya que se cargan todos de manera obligatoria, sin mas opciones
            {
                try
                {
                    IDbCommand cmd = ctn.CreateCommand();
                    cmd.CommandText = "Update EMPLE SET APELLIDO=@ape, OFICIO=@ofi, FECHA_ALT=@fech, SALARIO=@sal, COMISION=@com WHERE EMP_NO=@id";

                    cmd.Parameters.Add(new OleDbParameter("@ape", txtApellidos.Text));
                    cmd.Parameters.Add(new OleDbParameter("@ofi", txtOficio.Text));
                    cmd.Parameters.Add(new OleDbParameter("@fech", txtFechaAlta.Text));
                    cmd.Parameters.Add(new OleDbParameter("@sal", txtSalario.Text));
                    cmd.Parameters.Add(new OleDbParameter("@com", txtComision.Text));
                    cmd.Parameters.Add(new OleDbParameter("@id", txtOcultoID.Text));

                    cmd.ExecuteNonQuery();

                    lstbDepartamento_Click(lstbSeleccionado, e);//vuelve a actualizar la lista.

                }catch(Exception ex) { MessageBox.Show(ex.Message); }
                

            }
            else
            {
                MessageBox.Show("Escoja una fila a actualizar.");
            }


        }

        private void lstbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = lstbDepartamento.SelectedIndex;

            lstbIDdepartamento.SelectedIndex = indiceSeleccionado;

            txtIDdepartamento.Text = lstbIDdepartamento.SelectedItem.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!(txtIDdepartamento.Text.Equals("")))
            {
                IDbCommand cmd = ctn.CreateCommand();
                cmd.CommandText="select MAX(EMP_NO) from emple;";//para buscar el mayor ID

                int idEmpleadoSIgiente = Convert.ToInt32(cmd.ExecuteScalar()) + 1;//suma +1, para siguiente empleado.
                //string valido = Convert.ToString(idEmpleadoSIgiente);

                try
                {

                    /*cmd = ctn.CreateCommand();
                    cmd.CommandText = "INSERT INTO EMPLE (EMP_NO, APELLIDO, OFICIO, FECHA_ALT, SALARIO, COMISION, DEPT_NO) " +
                              "VALUES (@id, @ape, @ofi, @fech, @sal, @com, @dep);";

                    cmd.Parameters.Clear();

                    cmd.Parameters.Add(new OleDbParameter("@ape", txtApellidos.Text));
                    cmd.Parameters.Add(new OleDbParameter("@ofi", txtOficio.Text));
                    cmd.Parameters.Add(new OleDbParameter("@fech", txtFechaAlta.Text));
                    cmd.Parameters.Add(new OleDbParameter("@sal", txtSalario.Text));
                    cmd.Parameters.Add(new OleDbParameter("@com", txtComision.Text));
                    cmd.Parameters.Add(new OleDbParameter("@id", idEmpleadoSIgiente));
                    //cmd.Parameters.Add(new OleDbParameter("@id", valido));
                    cmd.Parameters.Add(new OleDbParameter("@dep", txtIDdepartamento.Text));

                    cmd.ExecuteNonQuery();

                    lstbDepartamento_Click(lstbSeleccionado, e);//vuelve a actualizar la lista.*/


                    cmd.CommandText = "INSERT INTO EMPLE (EMP_NO, APELLIDO, OFICIO, FECHA_ALT, SALARIO, COMISION, DEPT_NO) " +
                              "VALUES (?,?,?,?,?,?,?);";

                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Numeric) { Value = idEmpleadoSIgiente });
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Char) { Value = txtApellidos.Text });
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar) { Value = txtOficio.Text });
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Date) { Value = DateTime.Parse(txtFechaAlta.Text) });
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Double) { Value = double.Parse(txtSalario.Text) });
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = int.Parse(txtComision.Text) });
                    cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = int.Parse(txtIDdepartamento.Text) });

                    cmd.ExecuteNonQuery();
                    lstbDepartamento_Click(lstbSeleccionado, e);


                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }


                //MessageBox.Show("el numero es:"+ idEmpleadoSIgiente);

            }
            else
            {
                MessageBox.Show("Escoja un departamento");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!(txtIDdepartamento.Text.Equals("")))
            {
                IDbCommand cmd = ctn.CreateCommand();
                cmd.CommandText = "DELETE from emple where EMP_NO=?";

                cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = int.Parse(txtOcultoID.Text) });
                cmd.ExecuteNonQuery();
                MessageBox.Show("Borrado");
                lstbDepartamento_Click(lstbSeleccionado, e);

            }
            else
            {
                MessageBox.Show("Escoja un empleado a borrar.");
            }
        }
    }
}
