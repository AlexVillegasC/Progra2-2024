using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab2.frander_504440503;

public class Circulo : Geometry
{

    public Circulo(string formas) : base(formas)
    {
    }

    public override void figura()
    {
        Console.WriteLine("Esta Figura es un Circulo");
    }

}