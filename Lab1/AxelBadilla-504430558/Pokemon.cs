using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.AxelBadilla_504430558
{
    public class Pokemon
    {
        public string Nombre { set; get; }
        public int Vida { set; get; } = 100;
        public int Ataque { set; get; }

        public Pokemon(string nombre, int vida, int ataque)
        { 
            this.Nombre = nombre;
            this.Vida = vida;
            this.Ataque = ataque;
        
        }


    }
}
