using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.DanielNunez_119040930;

public class DamaBlanca : Ajedrez
{
    public DamaBlanca(string movimiento): base(movimiento)
    {

    }
    public override void Mover()
    {
        Console.WriteLine("Dama a g6");
    }
}
