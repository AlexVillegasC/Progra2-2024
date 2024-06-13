namespace Lab1.BrendaEspinoza;

public class Pikachu : Pokemon
{
    /// <summary>
    /// Mi clase Pikachu
    /// </summary>
    /// <param name="ataque">Representa un ataque</param>
    /// <param name="vida"></param>
    /// <param name="nombre"></param>
    public Pikachu(int ataque, int vida, string nombre) : base(ataque, vida, nombre)
    {
        this.Ataque = ataque;
    }

    public override string AtaqueEspecial()
    {
        return "impact trueno";
    }
}