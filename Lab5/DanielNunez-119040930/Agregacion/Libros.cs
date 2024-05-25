
namespace Lab5.DanielNunez_119040930.Agregacion;

public class Libros
{
    public string Nombre { get; set; }
    public int Lanzamiento { get; set; }

    public Libros(string nombre, int lanzamiento)
    {
        Nombre = nombre;
        Lanzamiento = lanzamiento;
    }
}
