using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.StarlingQuiros_118640201.Composicion
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public Motor Motor { get; set; }

        public Vehiculo(string marca, string tipoMotor)
        {
            Marca = marca;
            Motor = new Motor(tipoMotor); // Composición: el vehículo crea su propio motor
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca del Vehículo: {Marca}");
            Motor.MostrarInformacion();
        }
    }

}
