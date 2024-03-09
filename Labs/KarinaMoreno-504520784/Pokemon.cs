namespace Lab1.KarinaMoreno_504520784;

public class Pokemon
{
    private int Vida { get; set; }

    private int Ataque { get; set; }
    
    private string Nombre { get; set; }

    public Pokemon (int ataque, int vida, string nombre) 
    {
        this.Ataque = ataque;
        this.Vida = vida;
        this.Nombre = nombre;
    }

}