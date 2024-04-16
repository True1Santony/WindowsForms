using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiControlHotel
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public ComboBox getComboBoxClientes()
        {
            return comboBoxNombreApellido;
        }

        public TextBox getTextBoxNombre()
        {
            return txtbNombre;
        }
        public TextBox getTextBoxApellido()
        {
            return txtbApellido;
        }
        public TextBox getTextBoxTelefono()
        {
            return txtbTelefono;
        }
        public TextBox getTextBoxComentario()
        {
            return txtbComentario;
        }
    }
}
