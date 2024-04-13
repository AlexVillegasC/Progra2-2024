namespace Lab4.AlondraFlores_504590983;

public class McDonal<T>
{
    private List<T> comidas = new List<T>();

    public void Agregar(T comida)
    {
        comidas.Add(comida);
    }

    public void MostrarMenu()
    {
        Console.WriteLine("----Menu--------");
        foreach (var comida in comidas)
        {
            Console.WriteLine(comida);
        }
    }
}

