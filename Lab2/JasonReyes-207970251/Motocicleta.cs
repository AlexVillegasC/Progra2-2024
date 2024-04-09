<<<<<<< HEAD
﻿namespace Lab2.JasonReyes;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.JasonReyes;
>>>>>>> e793bcd (Lab2 final changes)

public class Motocicleta : Vehiculo
{

    public Motocicleta(string marca, string modelo, string color) : base(marca, modelo, color) { }


    public override void Arrancar()
    {
        Console.WriteLine("Encendiendo motocicleta...");
    }
}
