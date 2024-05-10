using NLayer.Architecture.Bussines.ReporteClima;

namespace NLayer.Architecture.Bussines.Services;


public interface IReporteClimaService
{
    Task<ReporteClima.ReporteClima> GetPronostico();
    Task AddTemperature(Temperature temperature);
<<<<<<< HEAD
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);
    Task<bool> DeleteTemperature();
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
}
