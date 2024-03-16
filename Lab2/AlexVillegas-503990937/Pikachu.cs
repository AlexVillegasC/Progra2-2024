
namespace Lab2.AlexVillegas;

public class Pikachu : Pokemon
{
    public Pikachu(int ataque, int vida, string Nombre) : base(ataque, vida, Nombre)
    {
    }

    public override void Atacar()
    {
        Console.WriteLine("Ataque Impactrueno!");
    }
}
