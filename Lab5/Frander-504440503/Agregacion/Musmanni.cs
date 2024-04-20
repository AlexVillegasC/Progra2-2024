namespace Lab5.Frander_504440503.Agregacion;

public class Musmanni
{

    public List<Empleado> Empleados { get; set; }

    public Musmanni ()
    {
        Empleados = new List<Empleado> ();
    }

    public void agregarEmpleado (Empleado empleado)
    {
        Empleados.Add(empleado);
    }

}

/*
public class Program
{
    static void Main (string[] args)
    {
        Empleado empleado1 = new Empleado ("Frander", "Panadero", 21);
        Empleado empleado2 = new Empleado ("Orlando", "Cajero", 19);

        Musmanni musmanni = new Musmanni ();
        musmanni.agregarEmpleado (empleado1);
        musmanni.agregarEmpleado (empleado2);

    }
}

*/