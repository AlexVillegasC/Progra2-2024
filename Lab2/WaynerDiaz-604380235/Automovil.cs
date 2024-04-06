using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.WaynerDiaz_604380235
{
    public class Automovil : Vehiculo
    {
        public int NumeroDePuertas { get; set; }

        public Automovil (string marca, string modelo, int año, int numeroDePuertas)
            : base(marca, modelo, año)
        {
            NumeroDePuertas = numeroDePuertas;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Número de puertas: {NumeroDePuertas}");
        }
    }
}
