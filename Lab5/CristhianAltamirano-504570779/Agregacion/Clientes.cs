namespace Lab5.CristhianAltamirano_504570779.Agregacion;

public class Clientes
{
    public string Nombre { get; set; }

    public string Apellido { get; set; }
    public int Edad { get; set; }

    public int ID { get; set; }

    public Clientes(string nombre, string apellido, int edad, int iD)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        ID = iD;
    }

    //Metodo para imprimir los datos
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"ID: {ID}");
    }
}
