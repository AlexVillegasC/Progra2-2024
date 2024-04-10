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
    public void AtaqueHada()
=======
    public void AtaqueTierno()
>>>>>>> 273e860 (lab 3 y 4)
    {
        throw new NotImplementedException();
    }
}