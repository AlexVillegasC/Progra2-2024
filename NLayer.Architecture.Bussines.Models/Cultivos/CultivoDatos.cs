namespace NLayer.Architecture.Bussines.GestionCultivo;

public class CultivoDatos
{
    public string Nombre { get; set; }
    public required string EtapaDesarrollo { get; set; }
    public DateTime FechaSiembra { get; set; }
    public DateTime FechaCosecha { get; set; }
    public int CicloVegetativo { get; set; }
    public double UsoConsuntivo { get; set; }
    public double AreaCultivada { get; set; }
    public double RendimientoPotencial { get; set; }
}