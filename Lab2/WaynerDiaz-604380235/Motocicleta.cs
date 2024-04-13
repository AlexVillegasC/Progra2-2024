namespace Lab2.WaynerDiaz_604380235
{
    public class Motocicleta : Vehiculo
    {
        public bool TieneSidecar { get; set; }

        public Motocicleta(string marca, string modelo, int año, bool tieneSidecar)
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
