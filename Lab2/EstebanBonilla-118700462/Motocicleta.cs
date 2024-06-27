using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.EstebanBonilla_118700462
{
    public class Motocicleta : Transporte
    {
        public bool ConSidecar { get; set; }

        public Motocicleta(string fabricante, string tipo, int fabricacion, bool conSidecar)
            : base(fabricante, tipo, fabricacion)
        {
            ConSidecar = conSidecar;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Con sidecar: {ConSidecar}");
        }
    }
}