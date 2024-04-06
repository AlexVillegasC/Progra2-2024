
namespace Lab2.BaironFallas_118860753;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
public class Cuadrado : FiguraGeometrica
=======
public class Cuadrado:FiguraGeometrica
>>>>>>> 8f19392 (Lab2-clase abstracta con dos metodos.)
=======
public class Cuadrado : FiguraGeometrica
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
public class Cuadrado:FiguraGeometrica
>>>>>>> 8f19392 (Lab2-clase abstracta con dos metodos.)
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


