namespace Lab3.JohanaAguero;

public class Unicornio : ITipoArcoiris, ITipoFisico
{
    public int Vida { get; set; }
    public string Nombre { get; set; }

    protected Unicornio(int vida, string Nombre)
    {
        this.Vida = vida;
        this.Nombre = Nombre;
    }

    public void AtaqueArcoiris()
    {
        throw new NotImplementedException();
    }

    public void AtaqueFisico()
    {
        throw new NotImplementedException();
    }
}