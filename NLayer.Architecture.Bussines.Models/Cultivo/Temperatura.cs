using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Bussines.Models.Cultivo;

public class Temperatura
{
    public int Valor { get; set; }
    public string Unidad { get; set; }
    public DateTime fechaActual { get; set; }
    public string Ubicacion { get; set; }

}
