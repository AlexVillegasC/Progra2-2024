namespace NLayer.Architecture.Bussines.ReporteClima;

public class ReporteClima
{
    public string Nombre { get; set; } = "Mi Reporte del Clima";

    public DateOnly Date => DateOnly.FromDateTime(DateTime.Now);

    public List<Wind> Viento { get; set; }

    public List<Temperature> Temperatura { get; set; }

    public List<Moisture> Humedad { get; set; }
}