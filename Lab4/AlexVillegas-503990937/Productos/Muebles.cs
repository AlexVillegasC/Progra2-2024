using System.Xml.Linq;

namespace Lab4.AlexVillegas_503990937.Productos;

public class Muebles
{
    public string Name { get; set; }

    public Muebles(string name)
    {
        this.Name = name;
    }

    public override string ToString()
    {
        return $"Name: {Name}";
    }
}
