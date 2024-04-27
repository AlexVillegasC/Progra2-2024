using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.axel_castillo_zuniga_504250653
{
    public class Multiplicacion:Calculadora
    {
        public decimal resultado;


        public Multiplicacion(int num0,int num1):base(num0,num1)
        {
                
        }
        public override decimal operation()
        {
            resultado = num0 * num1;

            return resultado;
            
        }
    }
}
