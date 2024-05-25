namespace NLayer.Architecture.Bussines.GestionCultivo;

public class GestionCultivo
{
    public string Nombre { get; set; } = "Gestion de Cultivos";

    public CultivoDatos CultivoDatos { get; set; }
    public Reservorio Reservorio { get; set; }
    public CoeficienteCultivo CoeficienteCultivo { get; set; }
    public double Eto { get; set; }
}
