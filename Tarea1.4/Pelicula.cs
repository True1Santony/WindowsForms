using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1._4
{
    class Pelicula
    {
        private string titulo;
        private string actores;
        private string directores;
        private string clasificacion;

        public Pelicula(string titulo, string actores, string directores, string clasificacion)
        {
            this.titulo = titulo;
            this.actores = actores;
            this.directores = directores;
            this.clasificacion = clasificacion;

        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Actores
        {
            get { return actores; }
            set { actores = value; }
        }

        public string Directores
        {
            get { return directores; }
            set { directores = value; }
        }

        public string Clasificacion
        {
            get { return clasificacion; }
            set { clasificacion = value; }
        }
    }
}
