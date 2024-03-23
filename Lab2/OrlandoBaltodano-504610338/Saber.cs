
namespace Lab2.OrlandoBaltodano;

public class Saber : Sirvientes
{
    public Saber(string nombre,int vida, int ataque) : base(nombre, vida, ataque)
    {
    }

    public override void Atacar()
    {
        Console.WriteLine("¡Excalibur!");
    }
}
