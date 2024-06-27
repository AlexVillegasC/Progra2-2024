

namespace Lab5.ArianaHernandez_504520730.Composicion;

public class Empresa
{
    public Empleados empleado { get; private set; }
    public Jefe jefe{ get; private set; }

    public Empresa()
    {
        empleado = new Empleados();
        jefe = new Jefe();
    }
}


//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Empresa empresa = new Empresa();
//        Console.WriteLine($"Nombre: {empresa.Jefe.Nombre}");
//        Console.WriteLine($"AniosExperiencia: {empresa.Jefe.Nombre}");
//        Console.WriteLine($"Nombre: {empresa.Empleado.Nombre}");
//        Console.WriteLine($"Puesto: {empresa.Empleado.Puesto}");
//    }
//}