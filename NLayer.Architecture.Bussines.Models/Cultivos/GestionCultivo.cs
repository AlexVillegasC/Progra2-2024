namespace NLayer.Architecture.Bussines.GestionCultivo;

public class GestionCultivo
{
    public string Nombre { get; set; } = "Gestion de Cultivos";

    public List<CultivoDatos> CultivoDatos { get; set; }
    public List<Reservorio> Reservorio { get; set; }
    public List<CoeficienteCultivo> CoeficienteCultivo { get; set; }
    public double Eto { get; set; }
}