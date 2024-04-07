

namespace Lab1.jasonreyes;
using System;
using System.Collections.Generic;
using System.Linq;



public class Giggly : Pokemon
{
    public Giggly(int ataque, int vida, string nombre) : base(ataque, vida, nombre)
    {
        this.Ataque = ataque;
        this.Vida = vida;
        this.Nombre = nombre;
    }
}

