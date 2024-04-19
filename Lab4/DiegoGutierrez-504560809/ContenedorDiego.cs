namespace Lab4.DiegoGutierrez_504560809
{
    public class ContenedorDiego<T>
    {
        private List<T> objetos = new List<T>();

        public void AgregarObjetos(T Objetos) 
        { 
            objetos.Add(Objetos);
        }

        public void MostrarObjetos() 
        {
            Console.WriteLine("Objetos almacenados en la mochila");
            foreach(var Objetos in objetos)    
            {
                Console.WriteLine(Objetos);
            }
        }
    }
}
