using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.JasonReyes;

public class Giggly : Pokemon
{
    public Giggly(int ataque, int vida, string nombre) : base(ataque, vida, nombre)
    {
        this.Ataque = ataque;
        this.Vida = vida;
        this.Nombre = nombre;
    }
}
