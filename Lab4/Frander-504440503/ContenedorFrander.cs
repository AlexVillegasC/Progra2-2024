using System.Runtime.CompilerServices;  
namespace Lab4.Frander_504440503;

class contenedorFrander <T>
{

    private List<T> elementos = new List<T>();


    public contenedorFrander(T elemento)
    {
        elementos.Add(elemento);
        Console.WriteLine("Persona agregada con exito...");
    }

    public void MostrarElementos()
    {
        Console.WriteLine("       Personas Registradas");
        Console.WriteLine("......................................");

        foreach (var elemento in elementos)
        {
            Console.WriteLine(elementos);
        }
        Console.WriteLine("......................................");
    }
}
