namespace Lab5.JohanaAguero;

class Bicicleta
{
    public string Modelo { get; set; }
    public string Tipo { get; set; }

    public Bicicleta(string modelo, string tipo)
    {
        Modelo = modelo;
        Tipo = tipo;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Tipo: " + Tipo);
    }
}

