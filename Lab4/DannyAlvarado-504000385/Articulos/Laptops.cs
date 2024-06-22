using System.Xml.Linq;

namespace Lab4.DannyAlvarado_504000385.Articulos;

public class Laptops
{
    public string Nombre { get; set; }

    public Laptops(string nombre)
    {
        Nombre = nombre;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}";
    }
}