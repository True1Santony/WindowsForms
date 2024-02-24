using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionDeControles
{
    class Cliente
    {
        private string nombre;
        private string apellido;
        private string telefono;
        private string comentario;

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }
        public void setComentario(string comentario)
        {
            this.comentario = comentario;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
        public string getTelefono()
        {
            return telefono;
        }
        public string getComentario()
        {
            return comentario;
        }

    }
}
