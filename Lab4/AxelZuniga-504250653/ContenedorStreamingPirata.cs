using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.AxelZuniga_504250653
{
    public class ContenedorStreamingPirata<T>
    {
        private List<T> peliculas=new List<T>();

        public void agregar(T pelicula)
        {
            peliculas.Add(pelicula);
        }

        public void mostrarPeliculas() {
            Console.WriteLine("Las peliculas disponibles son: ");

            foreach(T pelis in peliculas) {
            Console.WriteLine(pelis);
            }

        }

    }
}
