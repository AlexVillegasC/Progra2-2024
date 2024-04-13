namespace Lab4.Frander_504440503;

public class contenedorFrander<T>
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
