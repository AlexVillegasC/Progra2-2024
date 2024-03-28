namespace Lab2.AlexVillegas;

public class Charizard : Pokemon
{
    public Charizard(int ataque, int vida, string Nombre) : base(ataque, vida, Nombre)
    {
    }

    /// <summary>
    /// Atacar.
    /// </summary>
    public override void Atacar()
    {
        Console.WriteLine("Lanzallamas!");
    }
}
