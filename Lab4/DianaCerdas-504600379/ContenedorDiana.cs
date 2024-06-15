
namespace Lab4.DianaCerdas_504600379;

public class ContenedorDiana<T>
{
    private List<T> elementos = new List<T>();

    public void Agregar(T elemento)
    {
        elementos.Add(elemento);
    }


    public void MostrarElementos()
    {
        Console.WriteLine("--ELEMENTOS--");
        foreach (var elemento in elementos)
        {
            Console.WriteLine(elemento);
        }
    }

}