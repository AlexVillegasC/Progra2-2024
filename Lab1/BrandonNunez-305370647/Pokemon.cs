
namespace Lab1.BrandonNunez_305370647
{
    public class Pokemon
    {
        public int vida { get; set; } = 100;

        public int ataque { get; set; }

        protected string nombre { get; set; }

        public Pokemon(int vida, int ataque, string nombre)
        {
            this.vida = vida;
            this.ataque = ataque;
            this.nombre = nombre;
        }
    }
}
