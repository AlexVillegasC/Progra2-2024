using NLayer.Architecture.Bussines.ReporteClima;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteClimaRepository
{
    Task<Temperature> GetTemperatures();

    Task<Wind> GetWinds();

    Task<Moisture> GetMoisture();
}