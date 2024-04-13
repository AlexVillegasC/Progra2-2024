namespace Lab2.WaynerDiaz_604380235
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }

        // Constructor con sobrecarga
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Año = DateTime.Now.Year; // Año actual por defecto
        }

        public Vehiculo(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}");
        }

        public void Arrancar()
        {
            Console.WriteLine("El vehículo ha arrancado.");
        }

        public void Arrancar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }

}
