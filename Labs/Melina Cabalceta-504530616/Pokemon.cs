

namespace Lab1.Melina_Cabalceta_504530616
{
    public class Pokemon
    {
       public int Ataque { get; set; } 

        public int Vida { get; set; } = 100;
        public string Nombre { get; set; }


        /// <summary>
        /// Mi clase Pokemon
        /// </summary>
        /// <param name="ataque">Esto representa un ataque</param>
        /// <param name="vida"></param>
        /// <param name="Nombre"></param>

        public Pokemon(int ataque, int vida, string nombre)
        {
            this.Ataque = ataque;
            this.Vida = vida;
            this.Nombre = nombre;
        }
    }
  
}
