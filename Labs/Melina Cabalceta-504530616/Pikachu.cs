

namespace Lab1.Melina_Cabalceta_504530616
{
    public class Pikachu : Pokemon //Pikachu hereda de Pokemon 
    {
        /// <summary>
        /// Mi clase Pikachu
        /// </summary>
        /// <param name="ataque">Representa un ataque</param>
        /// <param name="vida"></param>
        /// <param name="nombre"></param>

        public Pikachu(int ataque, int vida, string nombre) : base(ataque, vida, nombre)
        {
            this.Ataque = ataque;
            this.Vida = vida;
            this.nombre = nombre;
        }
    }
}
