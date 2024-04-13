namespace Lab3.WaynerDíaz;

public class  Goku : IKamehameha, ITeletransportacion
{
    public string Poder { get; set; }
    public string Nombre { get; set; }

    protected Goku (string Poder, string Nombre)
    {
        this.Poder = Poder;
        this.Nombre = Nombre;
    }
    public void SuperSaiyan()
    {
        throw new NotImplementedException();
    }
    public void Kamehameha()
    {
        throw new NotImplementedException();
    }

    public void Teletransportacion()
    {
        throw new NotImplementedException();
    }

}