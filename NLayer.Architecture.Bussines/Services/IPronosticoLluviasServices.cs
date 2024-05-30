using NLayer.Architecture.Bussines.PronosticoLluvias;
using NLayer.Architecture.Bussines.Models.MonitoreoClimatico;

namespace NLayer.Architecture.Bussines.Services;

    public interface IPronosticoLluviasServices
    {
        Task<PronosticoLluvias.PronosticoLluvias> GetPronosticos();
    }

