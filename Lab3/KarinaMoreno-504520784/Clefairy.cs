namespace Lab3.KarinaMoreno;

public class Clefairy : ITipoHada, ITipoMagico
{

    public int Vida { get; set; }

    public string Nombre { get; set; }

    protected Clefairy(int vida, string nombre)
    {
        this.Vida = vida;
        this.Nombre = nombre;
    }

    public void AtaqueMagico()
    {
        throw new NotImplementedException();
    }

    public void AtaqueHada()
    {
        throw new NotImplementedException();
    }
}