using System.Xml.Linq;

namespace Lab4.CristhianAltamirano_504570779.Vehiculoss;

public class Carross
{
    public string Model { get; set; }

    public Carross(string model)
    {
        this.Model = model;
    }

    public override string ToString()
    {
        return $"Model: {Model}";
    }
}
