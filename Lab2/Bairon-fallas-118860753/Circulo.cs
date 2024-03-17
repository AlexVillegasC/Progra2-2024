
namespace Lab2.Bairon_fallas;

public class Circulo : FiguraGeometrica
{
    public float Radio { get; set; }
    public Circulo(string name, float radio) : base(name)
    {
        this.Radio = radio;
    }

    public override void CalcularArea()
    {
        float area = (float)(Math.PI * Math.Pow(Radio, 2));
        Console.WriteLine($"Area: {area}");
    }

    public override void CalcularPerimetro()
    {
        float perimetro = (float)(2* Math.PI * Radio);
            Console.WriteLine($"Perimetro: {perimetro}");
    }
}

        

     