using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.BrayanPérez_504510529
{
    public class Pokemon
    {
        public int Vida { get; set; } = 100;

        public int Ataque { get; set; }

        public string Nombre { get; set; }


        public Pokemon(int vida, int ataque, string nombre)
        {
            this.Vida = vida;
            this.Nombre = nombre;


        }
    }
}
