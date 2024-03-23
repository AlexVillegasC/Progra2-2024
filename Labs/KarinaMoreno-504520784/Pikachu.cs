namespace Lab1.KarinaMoreno_504520784;

public class Pikachu : Pokemon
{
    public Pikachu (int ataque, int vida, string nombre) : base(ataque, vida, nombre)
    {
        this.Ataque = ataque;
        this.Vida = vida;
        this.Nombre = nombre;
    }
}