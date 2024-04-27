namespace Lab1.axel_castillo_zuniga_504250653
{
    public class Charmander : Pokemon
    {
        public Charmander(string name, int vida, int ataque) : base(name, vida, ataque)
        {
            this.Name = name;
            this.Ataque = ataque;
            this.Vida = vida;
        }
    }
}
