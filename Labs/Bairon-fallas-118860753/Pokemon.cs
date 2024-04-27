namespace Lab1.Bairon_fallas;

public class Pokemon
{
    public int Vida { get; set; } = 100;
    public int Ataque { get; set; }

    public Pokemon(int vida, int ataque)
    {
        this.Ataque = ataque;
        this.Vida = vida;
    }

}