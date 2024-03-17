using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Bairon_fallas;

public class Cuadrado : FiguraGeometrica
{
    public float Lado { get; set; }
    public Cuadrado(string name, float lado) : base(name)
    {
        this.Lado = lado;
    }

    public override void CalcularArea()
    {
        float area = Lado * Lado;
        Console.WriteLine($"Area:{area}");
    }

    public override void CalcularPerimetro()
    {
        float perimetro = 4 * Lado;
        Console.WriteLine($"Perimetro: {perimetro}");
    }
}


