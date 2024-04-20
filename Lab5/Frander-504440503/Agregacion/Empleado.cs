namespace Lab5.Frander_504440503;

public class Empleado
{
    public string Nombre { get; set; }
    public string Puesto { get; set; }
    public int Edad { get; set; }

    public Empleado(string nombre, string puesto, int edad)
    {
        this.Nombre = nombre;
        this.Puesto = puesto;
        this.Edad = edad;
    }
    
}