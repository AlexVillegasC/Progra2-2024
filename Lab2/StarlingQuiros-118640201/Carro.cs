

namespace Lab2.StarlingQuiros_118640201

{
    public class Carro : Vehiculo
    {
        public int NumeroDePuertas { get; set; }

        public Carro(string marca, string modelo, int año, int numeroDePuertas)
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
