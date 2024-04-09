using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.JasonReyes;

public class Carro : Vehiculo
{
   

    public Carro(string marca, string modelo, string color): base(marca, modelo, color) 
    {
    }

 

    public override void Arrancar()
    {
        Console.WriteLine("Encendiendo el carro...");
    }
}
