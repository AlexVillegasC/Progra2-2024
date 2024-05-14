
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Melina_Cabalceta_504530616
{
    public class Pokemon
    {
       public int Ataque { get; set; } 

        public int Vida { get; set; }
        public string Nombre { get; set; }


        public Pokemon(int ataque, int vida, string nombre)
        {
            Ataque = ataque;
            Vida = vida;
            Nombre = nombre;
        }
    }
  
}
