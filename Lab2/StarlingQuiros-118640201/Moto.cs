

namespace Lab2.StarlingQuiros_118640201
{
    public class Moto : Vehiculo
    {
        public bool TieneSidecar { get; set; }

        public Moto(string marca, string modelo, int año, bool tieneSidecar)
            : base(marca, modelo, año)
        {
            TieneSidecar = tieneSidecar;
        }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Tiene sidecar: {TieneSidecar}");
        }
    }
}
