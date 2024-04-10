namespace Lab4.KarinaMoreno_504520784;

public class ContenedorKarina<T>
{
    private List<T> objetos = new List<T>();

    public void agregar(T objeto)
    {
        objetos.Add(objeto);
    }

    public void mostrarObjetos()
    {
        Console.WriteLine("Objetos en el contenedor: ");
        foreach (T objeto in objetos)
        {
            Console.WriteLine($"{objeto}");
        }
    }
}