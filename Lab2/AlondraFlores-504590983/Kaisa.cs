namespace Lab2.AlondraFlores_504590983;

public class Kaisa : Lol
{
    public Kaisa(int daño, int vida, string champ) : base(daño, vida, champ)
    {
    }

    public override void Atacar()
    {
        Console.WriteLine("Tirar primer Habilidad");
    }

}