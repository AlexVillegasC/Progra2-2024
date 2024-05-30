using NLayer.Architecture.Bussines.Models.MonitoreoClimatico;

namespace NLayer.Architecture.Bussines.PronosticoLluvias;

    public class PronosticoLluvias
    {
    public string Nombre { get; set; } = "Pronostico de Lluvias";

    public DateOnly Date => DateOnly.FromDateTime(DateTime.Now);

    public LluviaCortoPlazo LluviaCortoPlazo { get; set; }
    public LluviaLargoPlazo LluviaLargoPlazo { get; set; }
}

