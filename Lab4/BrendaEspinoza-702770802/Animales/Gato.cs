using System;
using System.Collections.Generic;

namespace Lab4.BrendaEspinoza_702770802.Animales;

public class Gato
{
    public string Name { get; set; }

    public  Gato(string name)
    {
        this.Name = name;
    }

    public override string ToString()
    {
        return $"Name: {Name}";
    }
}
