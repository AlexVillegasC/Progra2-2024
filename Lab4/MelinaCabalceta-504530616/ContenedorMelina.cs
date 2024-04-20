using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.MelinaCabalceta_504530616
{
    public class ContenedorMelina<T>
    {
        private List<T> elementos = new List<T>();

        public void Agregar(T elemento)
        {
            elementos.Add(elemento);
        }

        public void MostrarElemetos()
        {
            Console.WriteLine("Elementos en el contenedor");
            foreach (var elemento in elementos)
            {
                Console.WriteLine(elemento);
            }
        }


        static void Main(string[] args)
        {
            ContenedorMelina<Producto> miContenedorDeProductos = new ContenedorMelina<Producto>();
            Producto telefono = new Producto("Telefono", "Iphone");
            Producto Laptop = new Producto("Laptop", "Dell");
            Producto Reloj = new Producto("Reloj", "rolex");

            miContenedorDeProductos.Agregar(telefono);
            miContenedorDeProductos.Agregar(Laptop);
            miContenedorDeProductos.Agregar(Reloj);


            miContenedorDeProductos.MostrarElemetos();
        }
    }
}
