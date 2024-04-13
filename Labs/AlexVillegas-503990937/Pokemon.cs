namespace Lab1.AlexVillegas;

public class Pokemon
{
    public int Ataque { get; set; }

    public int Vida { get; set; }
    public string Nombre { get; set; }



    /// <summary>
    /// Mi clase Pokemon
    /// </summary>
    /// <param name="ataque">Esto representa un ataque</param>
    /// <param name="vida"></param>
    /// <param name="Nombre"></param>
    public Pokemon(int ataque, int vida, string nombre)
    {
        this.Vida = vida;
        this.Ataque = ataque;
        this.Nombre = nombre;
    }
}