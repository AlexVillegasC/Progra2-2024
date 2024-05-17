using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Bussines.Models.Cultivo;
// MI PARTE
public class HumedadSuelo
{
    public string Nombre { get; set; }
    public float nivelHumedad { get; set; }
    public DateOnly fechaActual { get; set; }
    public string Ubicacion { get; set; }


}
