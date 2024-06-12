using NLayer.Architecture.Bussines.Models.MonitoreoClimatico;
using NLayer.Architecture.Bussines.ReporteClima;

namespace NLayer.Architecture.Data.FileRepositories;

public interface IPronosticoLluviasRepository
{
    //Task<LluviaCortoPlazo> GetLluviaCortoPlazos();

    //Task<LluviaMedianoPlazo> GetLluviaMedianoPlazos();

    Task<List<LluviaLargoPlazo>> GetLluviaLargoPlazos();
    Task AddLluviaLargoPlazo(LluviaLargoPlazo _lluviaLargoPlazos);
    Task<bool> UpdateLluviaLargoPlazo(IEnumerable<LluviaLargoPlazo> _lluviaLargoPlazos);
    Task<bool> DeleteLluviaLargoPlazo();


}
