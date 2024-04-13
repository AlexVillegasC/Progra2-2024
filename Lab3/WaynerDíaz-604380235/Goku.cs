namespace Lab3.WaynerDíaz;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
public class Goku : IKamehameha, ITeletransportacion
=======
public class  Goku : IKamehameha, ITeletransportacion
>>>>>>> b8d7344 (Lab3)
=======
public class Goku : IKamehameha, ITeletransportacion
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
public class Goku : IKamehameha, ITeletransportacion
>>>>>>> origin/development
{
    public string Poder { get; set; }
    public string Nombre { get; set; }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    protected Goku(string Poder, string Nombre)
=======
    protected Goku (string Poder, string Nombre)
>>>>>>> b8d7344 (Lab3)
=======
    protected Goku(string Poder, string Nombre)
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
    protected Goku(string Poder, string Nombre)
>>>>>>> origin/development
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