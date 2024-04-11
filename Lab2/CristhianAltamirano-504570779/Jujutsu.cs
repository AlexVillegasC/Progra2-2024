
namespace Lab2.CristhianAltamirano;
public abstract class Jujutsu
{
    public int Ataque { get; set; }
    public int Vida { get; set; }
    public string Nombre { get; set; }
    public int Dominio { get; set; }

    protected Jujutsu(int ataque, int vida, string Nombre, int dominio)
    {
        this.Vida = vida;
        this.Ataque = ataque;
        this.Nombre = Nombre;
        this.Dominio = dominio;
    }

    public abstract void ExpansionDeDominio();

    public virtual void Entrada()
    {
        Console.WriteLine("La batalla entre los dos mas fuertes ha comenzado!");
    }
}

