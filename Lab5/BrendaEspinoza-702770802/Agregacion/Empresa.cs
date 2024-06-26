using System;
namespace Lab5.BrendaEspinoza_702770802.Agregacion;

public class Empresa
{
    public List<Empleado> Empleados { get; set; }

    public Empresa()
    {
        Empleados = new List<Empleado>();
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        Empleados.Add(empleado);
    }
}

/*namespace Lab5.BrendaEspinoza_702770802.Agregacion;
public class Program
{
    public static void Main(string[] args)
    {
       
        Empresa empresa = new Empresa();

        Empleado empleado1 = new Empleado("Shirley Matarrita", 45, 106780981);
        Empleado empleado2 = new Empleado("Heriberto Espinoza", 54, 508880888);
    
        empresa.AgregarEmpleado(empleado1);
        empresa.AgregarEmpleado(empleado2);

        Console.WriteLine("Empleados agregados:");
        foreach (Empleado emp in empresa.Empleados)
        {
            Console.WriteLine($"Nombre: {emp.Nombre} Edad: {emp.Edad} Id: {emp.Id}");
        }
    }
} */
