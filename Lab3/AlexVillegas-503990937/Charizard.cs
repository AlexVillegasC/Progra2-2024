namespace Lab3.AlexVillegas;

public class Charizard : ITipoVolador, ITipoFuego
{    
    public int Vida { get; set; }
    public string Nombre { get; set; }

    protected Charizard(int vida, string Nombre)
    {
        this.Vida = vida; 
        this.Nombre = Nombre;
    }

    public void AtaqueVolador()
    {
        throw new NotImplementedException();
    }

    public void AtaqueDragon()
    {
        throw new NotImplementedException();
    }

    public void AtaqueFuego()
    {
        throw new NotImplementedException();
    }
}
