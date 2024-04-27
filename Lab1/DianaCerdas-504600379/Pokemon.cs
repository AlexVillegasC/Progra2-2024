

namespace Lab1.DianaCerdas_504600379;

public class Pokemon
{

    public int Vida { get; set; } = 100;
    public int Ataque { get; set; }
    public string Nombre { get; set; }


    public Pokemon(int Vida, int Ataque, string Nombre)
    {
        this.Vida = Vida;
        this.Ataque = Ataque;
        this.Nombre = Nombre;
    }


}
