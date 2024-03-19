
namespace Lab2.OrlandoBaltodano;

public class Archer : Sirvientes
{
    public Archer(string nombre, int vida, int ataque) : base(nombre, vida, ataque)
    {
    }
    public override void Atacar()
    {
        Console.WriteLine("¡I am the bone of my sword. Steel is my body, and fire is my blood. I have created over a thousand blades. Unknown to death, nor known to life. Have withstood pain to create many weapons, yet those hands will never hold anything. So as I pray, Unlimited Blade Works.!");
    }
}
