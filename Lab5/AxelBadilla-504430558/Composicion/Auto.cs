
using Lab5.BaironFallas_118860753.Composicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.AxelBadilla_504430558.Composicion
{
    public class Auto
    {
        public Motor motor { private set; get; }
        public Motor motor1 { private set; get; }


        public Auto()
        {
            motor = new Motor();
            motor1 = new Motor();

        }
    }
}
