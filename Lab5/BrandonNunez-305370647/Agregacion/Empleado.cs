
namespace Lab5.BrandonNunez_305370647.Agregacion
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }

        public Empleado(string nombre, string cargo)
        {
            Nombre = nombre;
            Cargo = cargo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Cargo: {Cargo}");
        }
    }
}
