namespace NLayer.Architecture.Bussines.ReporteClima;

public class ReporteClima
{
    public string Nombre { get; set; } = "Mi Reporte del Clima";

    public DateOnly Date => DateOnly.FromDateTime(DateTime.Now);

    public Wind Viento { get; set; }

    public Temperature Temperatura { get; set; }

    public Moisture Humedad { get; set; }
}