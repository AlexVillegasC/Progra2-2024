namespace Lab2.DanielNunez_119040930;

public class DamaNegra : Ajedrez
{
    public DamaNegra(string movimiento)  : base(movimiento)
    {
       
    }

    public override void Mover()
    {
        Console.WriteLine("Dama a b7");
    }
}
