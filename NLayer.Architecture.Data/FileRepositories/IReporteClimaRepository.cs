using NLayer.Architecture.Bussines.ReporteClima;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteClimaRepository
{
    Task<List<Temperature>> GetTemperatures();

    Task<List<Wind>> GetWinds();

    Task<List<Moisture>> GetMoisture();

    Task AddTemperature(Temperature temp);
}