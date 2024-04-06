namespace Lab3.AlexVillegas;

public class Charizard
{    
    public int Vida { get; set; }
    public string Nombre { get; set; }

    protected Charizard(int vida, string Nombre)
    {
        this.Vida = vida; 
        this.Nombre = Nombre;
    }

    //AtaqueFuego();

    //AtaqueVolador();    
}
