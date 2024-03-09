
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> ae50c84 (Lab1 batalla pokemon)

namespace Lab1.Melina_Cabalceta_504530616
{
    public class Pokemon
    {
<<<<<<< HEAD
       public int Ataque { get; set; } 

        public int Vida { get; set; }
        public string Nombre { get; set; }


        public Pokemon(int ataque, int vida, string nombre)
        {
            Ataque = ataque;
            Vida = vida;
            Nombre = nombre;
=======
       public int Vida { get; set; } = 100;

        public int Ataque { get; set; }

        public string Nombre {  get; set; }
        public Pokemon(int vida, int ataque, string nombre)
        {
            this.Vida = vida;
            this.Ataque = ataque;
>>>>>>> ae50c84 (Lab1 batalla pokemon)
        }
    }
  
}
