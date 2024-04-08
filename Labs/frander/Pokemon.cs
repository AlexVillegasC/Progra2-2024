public class Pokemon
{
    public int Ataque { get; set; }

    public int Vida { get; set; }
    public string Nombre { get; set; }
    
    public Pokemon(int ataque, int vida, string Nombre) 
    { 
        this.Vida = vida;
        this.Ataque = ataque;
        this.Nombre = Nombre;
    }
}