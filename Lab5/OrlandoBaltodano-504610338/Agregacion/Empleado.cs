

namespace Lab5.OrlandoBaltodano.Agregacion;

internal class Empleado
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public int Edad { get; set; }

    public Empleado()
    {
        Nombre = "Marco";
        Apellidos = "Pérez";
        Edad = 23;
    }
}
