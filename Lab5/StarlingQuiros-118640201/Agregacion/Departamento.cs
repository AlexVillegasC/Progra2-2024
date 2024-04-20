namespace Lab5.StarlingQuiros_118640201.Agregacion
public class Departamento
    private string _nombre;
    private List<Empleado> _empleados;

    public Departamento(string nombre)
    {
        _nombre = nombre;
        _empleados = new List<Empleado>();
    }

    public void AgregarEmpleado(Empleado empleados)
    {
        _empleados.Agregar(empleado);
    }

    public void RemoverEmpleado(Empleado empleado)
    {
        _empleados.Remover(empleado);
    }
}
