using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.BrayanPérez_504510529
{
    internal class Zapdos : Pokemon
    {
        public Zapdos(int vida, int ataque, string nombre) : base(vida, ataque, nombre)
        {
            this.Ataque = ataque;
            this.Vida = vida;
            this.Nombre = nombre;

        }
    }
}
