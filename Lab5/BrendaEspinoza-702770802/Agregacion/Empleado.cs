using System;
namespace Lab5.BrendaEspinoza_702770802.Agregacion;

public class Empleado
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public int Id { get; set; }

    public Empleado(string nombre, int edad, int id)
    {
        Nombre = nombre;
        Edad = edad;
        Id = id;
    }
}