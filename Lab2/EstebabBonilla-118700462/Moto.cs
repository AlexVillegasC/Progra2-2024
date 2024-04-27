using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.EstebabBonilla_118700462;

    public class Moto : Vehiculo
{
    public bool TieneSidecar { get; set; }

    public Moto(string marca, string modelo, int año, bool tieneSidecar)
        : base(marca, modelo, año)
    {
        TieneSidecar = tieneSidecar;
    }

    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.WriteLine($"Tiene sidecar: {TieneSidecar}");
    }
}



