namespace Lab4.IsaiahRaust
{
    public class ContenedorIsaiah<T>
    {
        private List<T> Elementos = new List<T>();

        public void agregar(T elemento)
        {
            Elementos.Add(elemento);
        }

        public void eliminar(T elemento)
        {
            Elementos.Remove(elemento);
        }

        public void mostrar()
        {
            Console.WriteLine("Todos los usuarios registrados");
            foreach (var elemento in Elementos)
            {
                Console.WriteLine(elemento);
            }

        }

    }

}

