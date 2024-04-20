
namespace Lab5.OrlandoBaltodano.Agregacion;

internal class Empresa
{
    public List<Empleado> Empresas { get; set; }

    public Empresa()
    {
        Empresas = new List<Empleado>();
    }
    public void AgregarEmpleado(Empleado empleado)
    {
        Empresas.Add(empleado);
    }


}
