using NLayer.Architecture.Bussines.Models.MonitoreoClimatico;
using NLayer.Architecture.Bussines.ReporteClima;

namespace NLayer.Architecture.Data.FileRepositories;

public interface IPronosticoLluviasRepository
{
    Task<LluviaCortoPlazo> GetLluviaCortoPlazos();
    
    Task<LluviaLargoPlazo> GetLluviaLargoPlazos();

}
