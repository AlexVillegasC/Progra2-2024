using NLayer.Architecture.Bussines.Models.MonitoreoClimatico;

namespace NLayer.Architecture.Bussines.PronosticoLluvias;

    public class PronosticoLluvias
    {
    public string Nombre { get; set; } = "Pronostico de Lluvias";

    public DateOnly Date => DateOnly.FromDateTime(DateTime.Now);

    public List<LluviaCortoPlazo> LluviaCortoPlazo { get; set; }

    public List<LluviaMedianoPlazo> LluviaMedianoPlazo { get; set; }

    public List<LluviaLargoPlazo> LluviaLargoPlazo { get; set; }
}

