namespace Lab1.IsaiahRaust;

public class Gengar : Pokemon
{

    /// <summary>
    /// Mi clase Gengar
    /// </summary>
    /// <param name="ataque">Esto representa un ataque</param>
    /// <param name="vida"></param>
    /// <param name="nombre"></param>
    public Gengar(int ataque, int vida, string nombre) : base(ataque, vida, nombre)
    {

        this.Ataque = ataque;
        this.Vida = vida;
        this.Nombre = nombre;

    }

}


