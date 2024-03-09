
using global::Lab1.AlexVillegas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.Brandon_Nunez;

public class Gengar : Pokemon
{
    public Gengar(int ataque, int vida, string nombre) : base(ataque, vida, nombre)
    {
        this.Ataque = ataque;
        this.Vida = vida;
        this.Nombre = nombre;
    }
}
