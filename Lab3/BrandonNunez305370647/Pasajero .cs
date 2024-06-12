
namespace Lab3.BrandonNunez305370647
{
    public class Pasajero(string nombre) : ICompraBoleto, IElegirDestino, IReservarHotel
    {

        public string Nombre { get; set; } = nombre;
        public string Destino { get; set; }

        public void ReservarHotel()
        {
            Console.WriteLine("Habitacion de hotel reservado a nombre de: " + Nombre + "por tres noches");
        }
        public void ComprarBoleto()
        {
            Console.WriteLine("Boleto de avión comprado para " + Nombre);
        }

        public void ElegirDestino()
        {
            Console.WriteLine(Nombre + " ha elegido viajar a " + Destino);
        }
    }
}
