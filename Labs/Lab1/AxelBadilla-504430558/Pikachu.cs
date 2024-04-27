using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.AxelBadilla_504430558
{
    public class Pikachu : Pokemon
    {

        public Pikachu(string Nombre, int Vida, int Ataque) : base(Nombre, Vida, Ataque)
        {
            

            this.Nombre = Nombre;
            this.Vida = Vida;
            this.Ataque = Ataque;

        }



    }
}
