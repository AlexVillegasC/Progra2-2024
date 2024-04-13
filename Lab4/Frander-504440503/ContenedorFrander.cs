namespace Lab4.Frander_504440503;

<<<<<<< HEAD
public class contenedorFrander<T>
=======
class contenedorFrander<T>
>>>>>>> 2550663 (Merge with latest Dev changes)
{

    private List<T> elementos = new List<T>();

// Método para agregar elementos al contenedor
    public void Agregar(T elemento)
    {
        elementos.Add(elemento);
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
