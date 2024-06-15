using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.EstebanBonilla_118700462.Agregacion;
public class Viajero
{
    public int Identificacion { get; set; }

    public string PrimerNombre { get; set; }

    public string PrimerApellido { get; set; }

    public Viajero(int identificacion, string primerNombre, string primerApellido)
    {
        this.Identificacion = identificacion;
        this.PrimerNombre = primerNombre;
        this.PrimerApellido = primerApellido;
    }
}
