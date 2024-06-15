using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.JasonReyes.Composicion;

public class SistemaDeVision
{

public int Brillo {  get; set; }
public int Contraste {  get; set; } 
public int Nitidez { get; set; }


    public SistemaDeVision()
    {
        Brillo = 100;
        Contraste = 50;
        Nitidez = 100;
    }

    
}
