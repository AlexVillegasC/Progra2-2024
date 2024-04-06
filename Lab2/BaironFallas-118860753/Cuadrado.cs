
namespace Lab2.BaironFallas_118860753;

public class Cuadrado:FiguraGeometrica
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


