using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.axel_castillo_zuniga_504250653
{
    public abstract class Calculadora
    {
        public int num0 {  get; set; }
        public int num1 { get; set; }

        public Calculadora(int num0,int num1)
        {
            this.num0 = num0;
            this.num1 = num1;
            
        }


        public abstract decimal operation();
    }
}
