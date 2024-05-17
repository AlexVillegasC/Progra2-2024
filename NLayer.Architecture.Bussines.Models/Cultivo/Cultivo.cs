using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Bussines.Models.Cultivo;

public class Cultivo
{
    public string Nombre { get; set; }
    public string tipoCultivo { get; set; }
    public DateTime fechaPlantacion { get; set; }
    public string frecuenciaRiego { get; set; }

}
