using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace Lab4.BrendaEspinoza_702770802.Animales;

public class Perro
{
    public string Name { get; set; }

    public Perro(string name)
    {
        Name = name;
    }


    public override string ToString()
    {
        return $"Name: {Name}";
    }
}
