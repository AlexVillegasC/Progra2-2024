using System.Diagnostics;
using System.Xml.Linq;

namespace Lab4.CristhianAltamirano_504570779.Vehiculoss;

public class Motoss
{
    public string Model { get; set; }

    public Motoss(string model)
    {
        this.Model = model;
    }

    public override string ToString()
    {
        return $"Model: {Model}";
    }
}
