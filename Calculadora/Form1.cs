using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{


    public partial class Form1 : Form
    {
        double Primero = 0;
        double Segundo = 0;
        string Operacion="";
        double Memoria = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCero_Click(object sender, EventArgs e)
        {
            var botonNumeros = (Button)sender;


            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += botonNumeros.Text;
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMas_Click(object sender, EventArgs e)//lo usare para todos los botones de operaciones
        {
            var botonNumeros = (Button)sender;

            if (botonNumeros.Text.Equals("+") || botonNumeros.Text.Equals("/") || botonNumeros.Text.Equals("-") || botonNumeros.Text.Equals("*"))
            {
                if (!txtResultado.Text.Equals("0")) 
                {

                    try
                    {
                        Primero = Convert.ToDouble(txtResultado.Text);// de string a double para hacer operaciones
                        Operacion = botonNumeros.Text;//para saber que operacion queremos hacer
                        //MessageBox.Show("he pasado por el if del boton mas");
                        txtResultado.Text = "0";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("El texto del campo txtResultado no es un número.", "Error", MessageBoxButtons.OK);

                    }
                }
            }
            else 
            { 

        txtResultado.Text = "0";
                //MessageBox.Show("he pasado por el else del boton mas");
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            

            if (Operacion.Equals("+"))
            {
                Segundo = Convert.ToDouble(txtResultado.Text);
                txtResultado.Text = (Primero + Segundo).ToString();
            }
            else if (Operacion.Equals("-"))
            {
                Segundo = Convert.ToDouble(txtResultado.Text);
                txtResultado.Text = (Primero - Segundo).ToString();
            }
            else if (Operacion.Equals("/"))
            {
                Segundo = Convert.ToDouble(txtResultado.Text);
                txtResultado.Text = (Primero / Segundo).ToString();
            }
            else if (Operacion.Equals("*"))
            {
                Segundo = Convert.ToDouble(txtResultado.Text);
                txtResultado.Text = (Primero * Segundo).ToString();
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnBorra_Click(object sender, EventArgs e)
        {

            double Primero = 0;
            double Segundo = 0;
            string Operacion = "";
            txtResultado.Text = "0";
        }

        private void btnBorraOperando_Click(object sender, EventArgs e)
        {

            txtResultado.Text = "0";
        }

        private void btnSumaALaMemoria_Click(object sender, EventArgs e)
        {
            
                Memoria += Convert.ToDouble(txtResultado.Text);
                txtResultado.Text = "0";
            
        }
        private void btnBorraMemoria_Click(object sender, EventArgs e)
        {
            Memoria = 0;
        }

        private void btnMuestraEnMemoria_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Memoria.ToString();
        }
    }
}
