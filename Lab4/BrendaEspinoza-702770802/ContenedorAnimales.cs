namespace Lab4.BrendaEspinoza_702770802.Animales;

public class ContenedorAnimalesV<T>
{
    private List<T> elementos = new List<T>(); 

   
    public void Agregar(T elemento)
    {
        elementos.Add(elemento);
    }

    
    public void MostrarElementos()
    {
        Console.WriteLine("Elementos en el contenedor:");
        foreach (var elemento in elementos)
        {
            Console.WriteLine(elemento);
        }
    }
}