using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.frander_504440503.composicion
{
    public class Cuerpo
    {
        public class CuerpoHumano
    {
        public Pulmon Pulmon { get; private set; }
        public Rinon Rinon { get; private set; }

        public CuerpoHumano()
        {
            Pulmon = new Pulmon();
            Rinon = new Rinon();
        }
    }
    }
}

/*
       CuerpoHumano cuerpoHumano = new CuerpoHumano();
        Console.WriteLine($"Función respiratoria del pulmón: {cuerpoHumano.Pulmon.FuncionRespiratoria}");
       Console.WriteLine($"Función de filtración del riñón: {cuerpoHumano.Rinon.FuncionFiltracion}");
        }
*/