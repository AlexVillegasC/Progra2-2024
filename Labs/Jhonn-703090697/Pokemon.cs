using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Jhonn_703090697
{
     public class Pokemon
    {
        public int vida { get; set; } = 100;

        public int ataque { get; set; }

        public string Nombre { get; set; }



        public Pokemon(int vida, int ataque, string Nombre)
        {
            this .vida = vida;
            this . Nombre = Nombre;
           

        }

    }

    
}
