
namespace Lab5.CristhianAltamirano_504570779.Agregacion;

public class Productos
{
    public string Nombre { get; set; }

    public int Precio { get; set; }

    public int ID { get; set; }

    public Productos(string nombre, int precio, int iD)
    {
        Nombre = nombre;
        Precio = precio;
        ID = iD;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: {Precio}");
        Console.WriteLine($"ID: {ID}");
    }
}
