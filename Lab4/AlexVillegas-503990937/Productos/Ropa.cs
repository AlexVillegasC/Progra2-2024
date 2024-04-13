using System.Diagnostics;
using System.Xml.Linq;

namespace Lab4.AlexVillegas_503990937.Productos;

public class Ropa
{
    public string Name { get; set; }

    public Ropa(string name) {  Name = name; }


    public override string ToString()
    {
        return $"Name: {Name}";
    }
}
