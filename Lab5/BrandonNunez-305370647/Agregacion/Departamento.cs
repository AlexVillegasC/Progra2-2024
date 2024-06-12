
namespace Lab5.BrandonNunez_305370647.Agregacion
{
    public class Departamento
    {
        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }

        public Departamento(string nombre)
        {
            Nombre = nombre;
            Empleados = new List<Empleado>();
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Departamento: {Nombre}");
            Console.WriteLine("Empleados:");
            foreach (var empleado in Empleados)
            {
                empleado.MostrarInformacion();
            }
        }
    }
}
