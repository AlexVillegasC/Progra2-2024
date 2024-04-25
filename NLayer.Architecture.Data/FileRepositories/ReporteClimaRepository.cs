using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Data;

namespace DataAccess.Layer.FileRepositories;

public class ReporteClimaRepository : FileRepository, IReporteClimaRepository
{
    private const string tempetarureVirtualPath = "../NLayer.Architecture.Data/Files/temperature.json";
    private const string windVirtualPath = "../NLayer.Architecture.Data/Files/wind.json";
    private const string moistureVirtualPath = "../NLayer.Architecture.Datar/Files/moisture.json";

    public async Task<Temperature> GetTemperatures()
    {
        return await ReadJsonFileAsync<Temperature>(tempetarureVirtualPath);
    }

    public async Task<Wind> GetWinds()
    {
        return await ReadJsonFileAsync<Wind>(windVirtualPath);
    }

    public async Task<Moisture> GetMoisture()
    {
        return await ReadJsonFileAsync<Moisture>(moistureVirtualPath);
    }
}