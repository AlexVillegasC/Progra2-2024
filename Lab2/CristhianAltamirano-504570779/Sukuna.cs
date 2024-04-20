
namespace Lab2.CristhianAltamirano;

public class Sukuna : Jujutsu
{
    public Sukuna(int ataque, int vida, string Nombre, int dominio) : base(ataque, vida, Nombre, dominio)
    {
    }

    public override void ExpansionDeDominio()
    {
        Console.WriteLine("Gege, Mahoraga salvenme.");
    }
}
