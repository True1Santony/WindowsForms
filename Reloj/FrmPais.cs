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
    public partial class FrmPais : Form
    {
        private string pais = "";
        private int diferencia;
        public FrmPais()
        {
            InitializeComponent();
        }

        private void btnApeptarPais_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombrePais.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor para el campo Nombre.");
                return; // Detener el flujo del método 
            }

            try
            {
                if (!string.IsNullOrEmpty(txtDiferenciaHora.Text))
                {
                    diferencia = int.Parse(txtDiferenciaHora.Text);
                    pais = txtNombrePais.Text;
                    Close();
                }
                else
                {
                    MessageBox.Show("El campo Diferencia Horaria está vacío.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un valor numérico para la Diferencia Horaria.");
            }
        }
        public string ObtenerTextoNombrePais()
        {
            return pais;
        }
        public int ObtenerIntDiferenciaHoraria()
        {
            return diferencia;
        }
    }
}
