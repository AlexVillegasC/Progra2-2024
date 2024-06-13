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
    }


