using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreacionDeControles
{
    public partial class FichaCliente : UserControl
    {
        private string clave;

        public FichaCliente()
        {
            InitializeComponent();
        }

        private void FichaCliente_Load(object sender, EventArgs e)
        {

        }

        public string getClave()
        {
            return clave;
        }

        public void setClave(string clave)
        {
            this.clave = clave;
        }

        public TextBox getTextBox1()
        {
            return textBox1;
        }
    }
}
