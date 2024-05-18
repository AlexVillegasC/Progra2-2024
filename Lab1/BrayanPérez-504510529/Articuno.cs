using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.BrayanPérez_504510529
{
    public class Articuno : Pokemon
    {
        public Articuno(int vida, int ataque, string nombre) : base(vida, ataque, nombre)
        {
            this.Ataque = ataque;
            this.Vida = vida;
            this.Nombre = nombre;

        }
    }
}
