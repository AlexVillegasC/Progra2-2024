namespace Lab5.JohanaAguero;

class Cliente
{
    public string Nombre { get; set; }
    public string DNI { get; set; }

    public Cliente(string nombre, string dni)
    {
        Nombre = nombre;
        DNI = dni;
    }

    public void MostrarInfo()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("DNI: " + DNI);
    }
}