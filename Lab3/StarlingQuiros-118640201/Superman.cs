


namespace Lab3.StarlingQuiros_118640201;
public class Superman : Ultravision, ITeletransportacion
{
    public string Poder { get; set; }
    public string Nombre { get; set; }

    protected Superman (string Poder, string Nombre)
    {
        this.Poder = Poder;
        this.Nombre = Nombre;
    }
    public void Ultraman()
    {
        throw new NotImplementedException();
    }
    public void Ultravision()
    {
        throw new NotImplementedException();
    }

    public void Teletransportacion()
    {
        throw new NotImplementedException();
    }

}