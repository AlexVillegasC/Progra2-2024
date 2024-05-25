using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.JasonReyes;

public class Pikachu : Pokemon
{
    public Pikachu(int ataque, int vida, string nombre) : base(ataque, vida, nombre) { 
        
         this.Ataque = ataque;
         this.Vida = vida;
         this.Nombre = nombre;
        }
}
