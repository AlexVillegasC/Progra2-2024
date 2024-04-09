<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace Lab2.JasonReyes;
=======
=======
>>>>>>> e793bcd (Lab2 final changes)
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.JasonReyes;
<<<<<<< HEAD
>>>>>>> e793bcd (Lab2 final changes)
=======
﻿namespace Lab2.JasonReyes;
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
>>>>>>> e793bcd (Lab2 final changes)

public abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Color { get; set; }


    protected Vehiculo(string marca, string modelo, string color)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Color = color;
    }




    public abstract void Arrancar();

    public virtual void Conducir()
    {
        Console.WriteLine("Conduciendo...");
    }


}