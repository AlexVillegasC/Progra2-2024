using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Bussines.Models.GestionCultivo
{
    public class Reservorio
    {
        public double VolumeTotal { get; set; }
        public double VolumenActual { get; set; }
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public double Profundidad { get; set; }
        public double EvaporacionEstanque { get; set; }
        public double AreaSuperficial { get; set; }
    }
}
