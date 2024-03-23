namespace Lab2.Alondra;

public class Yasuo : Lol
{
    public Yasuo(int daño, int vida, string champ) : base(daño, vida, champ)
    {
    }

    public override void Atacar()
    {
        Console.WriteLine("Tirar Segunda Habilidad");
    }
}
