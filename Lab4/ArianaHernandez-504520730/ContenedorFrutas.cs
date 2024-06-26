using Lab4.ArianaHernandez_504520730.Frutas;

namespace Lab4.ArianaHernandez_504520730
{
    public class ContenedorFrutas<T>
    {
        private List<T> elementos = new List<T>(); 

        public void Agregar(T elemento)
        {
            elementos.Add(elemento);
        }

        public void MostrarElementos()
        {
            Console.WriteLine("Frutas en el contenedor:");
            foreach (var elemento in elementos)
            {
                Console.WriteLine(elemento);
            }
        }

        internal void Agregar(Fruta fruta)
        {
            throw new NotImplementedException();
        }

        internal void Agregar(object fruta)
        {
            throw new NotImplementedException();
        }
    }
}