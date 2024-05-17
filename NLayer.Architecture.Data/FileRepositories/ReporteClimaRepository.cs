using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.GestionRiego;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

public class ReporteClimaRepository : FileRepository, IGestionRiegoRepository
{
    private string _tempetarureVirtualPath = "temperature.json";
    private string _windVirtualPath = "wind.json";
    private string _moistureVirtualPath = "moisture.json";

    private string FolderPath { get; set; }


    public ReporteClimaRepository(IConfiguration Configuration) 
    {
        FolderPath = $"{Configuration["Folders:Clima"]}";
        _tempetarureVirtualPath = FolderPath + _tempetarureVirtualPath;
    }  

    public async Task<Temperature> GetTemperatures()
    {
        return await ReadJsonFileAsync<Temperature>(_tempetarureVirtualPath);
    }

    public async Task<Wind> GetWinds()
    {
        return await ReadJsonFileAsync<Wind>(_windVirtualPath);
    }

    public async Task<Moisture> GetMoisture()
    {
        return await ReadJsonFileAsync<Moisture>(_moistureVirtualPath);
    }
}