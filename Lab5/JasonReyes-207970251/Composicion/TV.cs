using Lab5.AlexVillegas_503990937.Composicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.JasonReyes.Composicion;

public class TV
{
    public SistemaDeSonido SistemaDeSonido { get; private set; }
    public SistemaDeVision SistemaDeVision { get; private set; }

    public TV()
    {
        SistemaDeSonido = new SistemaDeSonido();
        SistemaDeVision = new SistemaDeVision();
    }
}
