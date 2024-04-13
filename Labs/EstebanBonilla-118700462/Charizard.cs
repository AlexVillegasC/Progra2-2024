using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.EstebanBonilla_118700462;


public class Charizard : Pokemon
{
    public Charizard(int vida, int ataque, string Nombre) : base(vida, ataque, Nombre)
    {
        this.ataque = ataque;

    }
}
