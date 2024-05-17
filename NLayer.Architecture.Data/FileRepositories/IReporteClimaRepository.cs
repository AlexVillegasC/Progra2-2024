using NLayer.Architecture.Bussines.GestionRiego;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteClimaRepository
{
    Task<Temperature> GetTemperatures();

    Task<Wind> GetWinds();

    Task<Moisture> GetMoisture();
}