using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.DanielNunez___119040930
{
    public class Pokemon
    {
        public int vida;
        public int ataque;
        protected string nombre;

        public Pokemon(int vida, int ataque, string nombre)
        {
            this.vida = vida;
            this.ataque = ataque;
            this.nombre = nombre;
        }
    }

}
