

namespace Lab1.Melina_Cabalceta_504530616
{
    public class Pokemon
    {
       public int Vida { get; set; } = 100;

        public int Ataque { get; set; }

        public string Nombre {  get; set; }
        public Pokemon(int vida, int ataque, string nombre)
        {
            this.Vida = vida;
            this.Ataque = ataque;
        }
    }
  
}
