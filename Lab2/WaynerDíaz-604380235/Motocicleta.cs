using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab2.WaynerDíaz
{
    public class Motocicleta : WaynerDiaz.Vehiculo
    {
        public bool TieneSidecar { get; set; }

        public Motocicleta(string marca, string modelo, int año, bool tieneSidecar)
            : base(marca, modelo, año)
        {
            TieneSidecar = tieneSidecar;
        }

        // Sobreescritura del método MostrarDetalles
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Tiene sidecar: {TieneSidecar}");
        }
    }
}