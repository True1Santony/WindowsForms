using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPulsar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Name.Equals("BtnPulsar"))

                TxtMensaje.Text = "HolaMundo";

            else

                TxtMensaje.Text = "Adios";

        }
    }
}
