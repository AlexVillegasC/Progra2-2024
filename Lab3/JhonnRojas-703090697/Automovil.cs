using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.JhonnRojas_703090697
{
    public class Automovil : IVehiculo
    {
        private Vehiculo_terrestre vehiculo_terrestre=new Vehiculo_terrestre();

        public void Acelerar()
        {
            Console.WriteLine();
        }

        public void Frenar()
        {
            Console.WriteLine();
        }

        public void Moverse_adelante()
        {
            vehiculo_terrestre.Moverse_adelante();
        }

        public void Moverse_atras()
        {
            vehiculo_terrestre.Moverse_atras(); 
        }
    }
}
