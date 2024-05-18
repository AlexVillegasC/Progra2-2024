using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Bussines.Models.GestionCultivo
{
    public class GestionCultivo
    {
        public CoeficienteCultivo coeficientecultivo { get; set; }

        public CultivoDatos cultivodatos { get; set; }

        public Reservorio reservorio { get; set; }

        public double Eto { get; set; }
    }

}
