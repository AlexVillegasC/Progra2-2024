namespace Lab2.Alondra;

public abstract class Lol
{
    public int Daño { get; set; }
    public int Vida { get; set; }
    public string Champ { get; set; }


    protected Lol(int daño, int vida, string Champ)
    {
        this.Vida = vida;
        this.Daño = daño;
        this.Champ = Champ;
    }

    public abstract void Atacar();

    public virtual void Entrada()
    {
        Console.WriteLine("Bienvenido a la Grieta del invocador");
    }
}
