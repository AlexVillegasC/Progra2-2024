
using Lab4.BrandonNunez_305370647.Opciones_Viajes;

namespace Lab4.BrandonNunez_305370647
{
    public class ContainerTrips<T>
    {
        private List<T> elementos = new List<T>();    //Se declara la lista para alamacenar elementos 

        public void AddElement(T elemento)  //Agregar elementos 
        {
            elementos.Add(elemento);
        }

        public void ShowElemets()   //Mostrar elementos con un foreach 
        {
            Console.WriteLine("Elementos de la lista");
            foreach (var elemento in elementos)
            {
                Console.WriteLine(elemento.ToString());
            }
        }

        internal void AddElement(MontainTrip montainTrip)
        {
            throw new NotImplementedException();
        }
    }
}

