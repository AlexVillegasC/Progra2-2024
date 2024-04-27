using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.JhonnRojas_703090697
{
    public class Bote:IVehiculo
    {
        private Vehiculo_acuatico vehiculo_acuatico=new Vehiculo_acuatico();

        public void Acelerar()
        {
            Console.WriteLine();
        }

        public void Frenar() 
        {
            Console.WriteLine(); 
        }
        
        public void Flotar()
        {
            vehiculo_acuatico.Flotar();
        }


    }
}
