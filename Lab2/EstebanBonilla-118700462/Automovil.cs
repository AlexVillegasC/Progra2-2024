using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.EstebanBonilla_118700462
{
    public class Automovil : Transporte
    {
        public int CantidadDePuertas { get; set; }

        public Automovil(string fabricante, string tipo, int fabricacion, int cantidadDePuertas)
            : base(fabricante, tipo, fabricacion)
        {
            CantidadDePuertas = cantidadDePuertas;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Cantidad de puertas: {CantidadDePuertas}");
        }
    }
}
