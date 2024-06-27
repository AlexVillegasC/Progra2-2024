namespace Lab4.DannyAlvarado_504000385;
public class ContenedorDanny<T>
{
    private List<T> elementos = new List<T>();

    public void Agregar(T elemento)
    {
        elementos.Add(elemento);
    }

    public void MostrarElementos()
    {
        Console.WriteLine("Elementos dentro el contenedor:");

        foreach (var elemento in elementos)
        {
            Console.WriteLine(elemento);
        }
    }
}

