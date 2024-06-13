using NLayer.Architecture.Bussines.PronosticoLluvias;
using NLayer.Architecture.Bussines.Models.MonitoreoClimatico;

namespace NLayer.Architecture.Bussines.Services;

    public interface IPronosticoLluviasServices
    {

        Task<PronosticoLluvias.PronosticoLluvias> GetPronosticos();

       Task GetLluviaCortoPlazos(LluviaCortoPlazo lluviaCortoPlazo);
       Task AddLluviaCortoPlazo(LluviaCortoPlazo lluviaCortoPlazo);

       Task<bool> UpdateLluviaCortoPlazo(IEnumerable<LluviaCortoPlazo> lluviaCortoPlazos);

       Task<bool> DeleteLluviaCortoPlazo();

    Task GetLluviaMedianoPlazos(LluviaMedianoPlazo lluviaMedianoPlazo);
    Task AddLluviaMedianoPlazo(LluviaMedianoPlazo lluviaMedianoPlazo);

    Task<bool> UpdateLluviaMedianoPlazo(IEnumerable<LluviaMedianoPlazo> lluviaMedianoPlazos);

    Task<bool> DeleteLluviaMedianoPlazo();

    Task GetLluviaLargoPlazos(LluviaLargoPlazo lluviaLargoPlazo);
        Task AddLluviaLargoPlazo(LluviaLargoPlazo lluviaLargoPlazo);

        Task<bool>UpdateLluviaLargoPlazo(IEnumerable<LluviaLargoPlazo>lluviaLargoPlazos);
       
        Task<bool>DeleteLluviaLargoPlazo();


}



