namespace NLayer.Architecture.Bussines.ReporteClima;

public class Wind
{
    /// <summary>
    /// Wind speed in meters per second
    /// </summary>
    public int Speed { get; set; }

    /// <summary>
    /// Wind direction in degrees
    /// </summary>
    public int Degree { get; set; }

    /// <summary>
    /// Wind direction in compass direction(N, S, E, W, NE, NW, SE, SW)
    /// </summary>
    public string Direction { get; set; }
}