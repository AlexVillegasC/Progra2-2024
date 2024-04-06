
namespace Lab2.BaironFallas_118860753;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
public class Circulo : FiguraGeometrica
=======
public class Circulo:FiguraGeometrica
>>>>>>> 8f19392 (Lab2-clase abstracta con dos metodos.)
=======
public class Circulo : FiguraGeometrica
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
public class Circulo:FiguraGeometrica
>>>>>>> 8f19392 (Lab2-clase abstracta con dos metodos.)
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
        float perimetro = (float)(2 * Math.PI * Radio);
        Console.WriteLine($"Perimetro: {perimetro}");
    }
}







