using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.EstebanBonilla_118700462.Composicion;
public class Motor
{
    public class MotorCompleto
    {
        public Pistones Pistones { get; private set; }
        public FiltroDeAire FiltroDeAire { get; private set; }

        public MotorCompleto()
        {
            Pistones = new Pistones();
            FiltroDeAire = new FiltroDeAire();
        }
    }
}
