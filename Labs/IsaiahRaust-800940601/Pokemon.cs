

namespace Lab1.IsaiahRaust;

public class Pokemon
{

    public int Vida { get; set; } = 100;

    public int Ataque { get; set; }

    public string Nombre { get; set; }
    

    /// <summary>
    /// Mi clase Pokemon.
    /// </summary>
    /// <param name="ataque">Esto representa un ataque</param>
    /// <param name="vida"></param>
    /// <param name="nombre"></param>

    public Pokemon(int ataque, int vida, string nombre)
    {

        this.Vida = vida;
        this.Ataque = ataque;
        this.Nombre = nombre;

    }


}
