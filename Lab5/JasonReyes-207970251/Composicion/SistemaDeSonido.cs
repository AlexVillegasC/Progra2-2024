using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.JasonReyes.Composicion;

public class SistemaDeSonido
{
    public int Volumen {  get; set; }

    public SistemaDeSonido()
    {
        Volumen = 0;
    }




    public void SubirVolumen(int volumen)
    {
        Console.WriteLine("Volumen +1");
    }

}
