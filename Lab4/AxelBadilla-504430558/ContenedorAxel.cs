using Lab4.AxelBadilla_504430558;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.AxelBadilla_504430558
{
    public class ContenedorAxel<T>
    {
        private List<T>  elementos = new List<T>();

        public void Agregar(T elemento)
        { 
        
        elementos.Add(elemento);
        
        }
        public void MostrarElementos()
        {

            Console.WriteLine("Elementos presentes en el contenedor:");
            foreach (var elemento in elementos)
            {

                Console.WriteLine(elemento);
            
            }
        
        }

    }
}


/*ContenedorAxel<Telefono> miContenedor = new Lab4.AxelBadilla_504430558.ContenedorAxel<Telefono>();
Telefono samsung = new Telefono("Samsung");
Telefono iPhone = new Telefono("iPhone");
miContenedor.Agregar(samsung);
miContenedor.Agregar(iPhone);
miContenedor.MostrarElementos();*/


