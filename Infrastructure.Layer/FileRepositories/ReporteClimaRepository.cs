using Domain.Models.ReporteClima;

namespace DataAccess.Layer.FileRepositories;

public class ReporteClimaRepository : FileRepository, IReporteClimaRepository
{
    private const string tempetarureVirtualPath = "../DataAccess.Layer/Files/temperature.json";
    private const string windVirtualPath = "../DataAccess.Layer/Files/wind.json";
    private const string moistureVirtualPath = "../DataAccess.Layer/Files/moisture.json";

    public async Task<List<Temperature>> GetTemperatures()
    {
        return await ReadJsonFileAsync<List<Temperature>>(tempetarureVirtualPath);
    }

    public async Task<List<Wind>> GetWinds()
    {
        return await ReadJsonFileAsync<List<Wind>>(windVirtualPath);
    }

    public async Task<List<Moisture>> GetMoisture()
    {
        return await ReadJsonFileAsync<List<Moisture>>(moistureVirtualPath);
    }
}
