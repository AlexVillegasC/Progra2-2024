namespace Lab3.AlexVillegas;

public class Charizard : Fuego, Volador
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
    protected Charizard(int ataque, int vida, string Nombre)
    {
        this.Vida = vida;
        this.Ataque = ataque;
        this.Nombre = Nombre;
    }

    public void AtaqueFuego()
    {
        throw new NotImplementedException();
    }

    public void AtaqueVolador()
    {
        throw new NotImplementedException();
    }
}
