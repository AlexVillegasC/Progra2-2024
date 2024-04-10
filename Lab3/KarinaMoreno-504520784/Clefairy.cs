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

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public void AtaqueHada()
=======
    public void AtaqueTierno()
>>>>>>> 273e860 (lab 3 y 4)
=======
    public void AtaqueHada()
>>>>>>> 0b4914f (interface changes)
=======
    public void AtaqueTierno()
>>>>>>> 273e860 (lab 3 y 4)
    {
        throw new NotImplementedException();
    }
}