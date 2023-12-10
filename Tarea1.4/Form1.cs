using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1._4
{
    public partial class Form1 : Form
    {

        List<Pelicula> listaPeliculas = new List<Pelicula>();
        HashSet<string> calificacionUnica = new HashSet<string>();//no admite duplicados
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int pos = 80;
            foreach(string line in System.IO.File.ReadLines(@"peliculas.txt", Encoding.Default))
            {
                string [] lista = line.Split('#');

                //MessageBox.Show(lista[0].Trim());

                Pelicula p = new Pelicula(lista[0].Trim(), lista[1].Trim(), lista[2].Trim(), lista[3].Trim());
                listaPeliculas.Add(p);
                calificacionUnica.Add(lista[3].Trim());
                
            }
            List<string> listaOrdenada = new List<string>(calificacionUnica);//para usar Sort()
            listaOrdenada.Sort();
            foreach (string s in listaOrdenada)
            {
                RadioButton r = new RadioButton();
                r.Text = s;
                r.Left = 50;
                r.Top = pos;
                r.Width = 200;
                pos += 20;
                r.Click += new System.EventHandler(this.ManejaCategorias);
                this.Controls.Add(r);

            }


        }
        private void ManejaCategorias(object sender, EventArgs e)
        {
            
            lstBxActores.Items.Clear();  //se limpian los listBox
            lstBxDirectores.Items.Clear();
            lstBxTitulos.Items.Clear();

            int marcadorActoresTitulos=0, marcadorDirectores=0;

            HashSet<string> directores = new HashSet<string>();//para que no se repitan los directores

            string category = ((RadioButton)sender).Text;//obtengo la categoria que ha sido seleccionada

            foreach (Pelicula p in listaPeliculas) //se recorren todas las peliculas
            {

                if (category.Equals(p.Clasificacion))//se obtiene la info comparando el parametro clasificacion de peliculas
                {
                    
                    lstBxActores.Items.Add(p.Actores);
                    lstBxTitulos.Items.Add(p.Titulo);
                    
                    directores.Add(p.Directores);//se agrega los directores al hashset para filtrar

                    marcadorActoresTitulos++;//veo que asi es como funciona en el ejemplo xd.
                }
            }
            foreach (string s in directores)
            {
                lstBxDirectores.Items.Add(s);
                marcadorDirectores++;
            }

            lblActores.Text = ("Actores: ("+marcadorActoresTitulos+")");
            lblDirectores.Text = ("Directores: ("+marcadorDirectores+")");
            lblTitulos.Text = ("Titulos: ("+marcadorActoresTitulos+")");
        }
    }
}
