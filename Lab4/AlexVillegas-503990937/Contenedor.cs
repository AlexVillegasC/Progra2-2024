namespace Lab4.AlexVillegas_503990937;

public class ContenedorAlex<T>
{
    private List<T> elementos = new List<T>(); // Lista para almacenar elementos de cualquier tipo

    // Método para agregar elementos al contenedor
    public void Agregar(T elemento)
    {
        elementos.Add(elemento);
    }

    // Método para mostrar los elementos del contenedor
    public void MostrarElementos()
    {
        Console.WriteLine("Elementos en el contenedor:");
        foreach (var elemento in elementos)
        {
            Console.WriteLine(elemento);
        }
    }
}
