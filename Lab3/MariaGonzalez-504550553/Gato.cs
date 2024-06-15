namespace Lab3.MariaGonzalez;

public class Gato : ITipoAgilidad, ITipoVision_Nocturna
{
    public int Vida { get; set; }
    public string Nombre { get; set; }

    protected Gato(int vida, string Nombre)
    {
        this.Vida = vida;
        this.Nombre = Nombre;
    }

    public void AtaqueAgilidad()
    {
        throw new NotImplementedException();
    }

    public void AtaqueVision_Nocturna()
    {
        throw new NotImplementedException();
    }
}
