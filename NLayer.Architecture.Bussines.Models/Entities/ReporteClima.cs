namespace NLayer.Architecture.Bussines.ReporteClima;

public class ReporteClima
{
    public DateOnly Date => DateOnly.FromDateTime(DateTime.Now);

    public Wind Viento { get; set; }

    public Temperature Temperatura { get; set; }

    public Moisture Humedad { get; set; }
}