using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.WaynerDiaz_604380235
{
    public class Pokemon
    {
        public int Ataque { get; set; }

        public int Vida { get; set; }
        public string Nombre { get; set; }



        /// <summary>
        /// Mi clase Pokemon
        /// </summary>
        /// <param name="ataque">Esto representa un ataque</param>
        /// <param name="vida"></param>
        /// <param name="Nombre"></param>
        public Pokemon(int ataque, int vida, string Nombre)
        {
            this.Vida = vida;
            this.Ataque = ataque;
        }
    }

}
