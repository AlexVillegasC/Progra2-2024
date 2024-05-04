namespace Lab1.BrendaEspinoza;

public class Snorlax : Pokemon
{
    /// <summary>
    /// Mi clase Pikachu
    /// </summary>
    /// <param name="ataque">Representa un ataque</param>
    /// <param name="vida"></param>
    /// <param name="nombre"></param>
    public Snorlax(int ataque, int vida, string nombre) : base(ataque, vida, nombre)
    {
        this.Ataque = ataque;
    }

    public override string AtaqueEspecial()
    {
       return "Snorlax golpe cuerpo";
    }
}
//hi
