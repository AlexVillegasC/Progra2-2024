using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.AlexVillegas;

public class Gengar : Pokemon
{
    public Gengar(int ataque, int vida, string nombre) : base(ataque, vida, nombre)
    {
        this.Ataque = ataque;
        this.Vida = vida;
        this.Nombre = nombre;
    }
}
