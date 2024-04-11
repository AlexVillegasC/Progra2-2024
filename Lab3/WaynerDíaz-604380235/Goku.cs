namespace Lab3.WaynerDíaz;

<<<<<<< HEAD
public class Goku : IKamehameha, ITeletransportacion
=======
public class  Goku : IKamehameha, ITeletransportacion
>>>>>>> b8d7344 (Lab3)
{
    public string Poder { get; set; }
    public string Nombre { get; set; }

<<<<<<< HEAD
    protected Goku(string Poder, string Nombre)
=======
    protected Goku (string Poder, string Nombre)
>>>>>>> b8d7344 (Lab3)
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