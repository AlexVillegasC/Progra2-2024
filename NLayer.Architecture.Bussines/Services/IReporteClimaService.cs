using NLayer.Architecture.Bussines.ReporteClima;

namespace NLayer.Architecture.Bussines.Services;


public interface IReporteClimaService
{
    Task<ReporteClima.ReporteClima> GetPronostico();
    Task AddTemperature(Temperature temperature);
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);
    Task<bool> DeleteTemperature();
}
