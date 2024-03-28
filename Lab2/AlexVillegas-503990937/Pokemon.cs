namespace Lab2.AlexVillegas;

public abstract class Pokemon
{
    public int Ataque { get; set; }
    public int Vida { get; set; }
    public string Nombre { get; set; }

    /// <summary>
    /// Mi clase Pokemon.
    /// </summary>
    /// <param name="ataque">Esto representa un ataque</param>
    /// <param name="vida"></param>
    /// <param name="Nombre"></param>
    protected Pokemon(int ataque, int vida, string Nombre)
    {
        this.Vida = vida;
        this.Ataque = ataque;
        this.Nombre = Nombre;
    }

    // Metodo Abstracto
    public abstract void Atacar();

    // Metodo Virtual
    public virtual void Entrada()
    {
        Console.WriteLine("Yo te elijo!");
    }
}
