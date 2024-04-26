unamespace Lab5.JohanaAguero;

class Alquiler
{
    public Cliente Cliente { get; set; }
    public Bicicleta Bicicleta { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }

    public Alquiler(Cliente cliente, Bicicleta bicicleta, DateTime fechaInicio, DateTime fechaFin)
    {
        Cliente = cliente;
        Bicicleta = bicicleta;
        FechaInicio = fechaInicio;
        FechaFin = fechaFin;
    }

}

