using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.JasonReyes.Composicion;

public class SistemaDeVision
{
    public int Brillo { get; set; }
    public int Contraste { get; set; }
    public int Tenacidad { get; set; }

    public SistemaDeVision()
    {
        Brillo = 0;
        Contraste = 0;
        Tenacidad = 0;
    }

    public void SubirBrillo(int volumen)
    {
        Console.WriteLine("Brillo +1");
    }

    public void SubirContraste(int volumen)
    {
        Console.WriteLine("Contraste +1");
    }

    public void SubirTenacidad(int volumen)
    {
        Console.WriteLine("Tenacidad +1");
    }


}
