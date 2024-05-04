using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Data;

namespace DataAccess.Layer.FileRepositories;

public class ReporteClimaRepository : FileRepository, IReporteClimaRepository
{
    private string _tempetarureVirtualPath = "temperature.json";
    private string _windVirtualPath = "wind.json";
    private string _moistureVirtualPath = "moisture.json";

    private string FolderPath { get; set; }


    public ReporteClimaRepository(IConfiguration Configuration) 
    {
        FolderPath = $"{Configuration["Folders:Clima"]}";
        _tempetarureVirtualPath = FolderPath + _tempetarureVirtualPath;
        _windVirtualPath = FolderPath + _windVirtualPath;
        _moistureVirtualPath = FolderPath + _moistureVirtualPath;
    }  

    public async Task<List<Temperature>> GetTemperatures()
    {
        return await ReadJsonFileAsync<List<Temperature>>(_tempetarureVirtualPath);
    }

    public async Task<List<Wind>> GetWinds()
    {
        return await ReadJsonFileAsync<List<Wind>>(_windVirtualPath);
    }

    public async Task<List<Moisture>> GetMoisture()
    {
        return await ReadJsonFileAsync<List<Moisture>>(_moistureVirtualPath);
    }
}