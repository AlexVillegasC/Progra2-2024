using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1.axel_castillo_zuniga_504250653
{
    public class Pikachu:Pokemon
    {
        public Pikachu(string Name,int Ataque, int Vida) : base(Name, Vida, Ataque)
        {
            this.Name = Name;
            this.Ataque = Ataque;
            this.Vida = Vida;
        }


    }
}
