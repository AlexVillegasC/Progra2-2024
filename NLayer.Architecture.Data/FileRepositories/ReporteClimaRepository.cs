using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

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
<<<<<<< HEAD
    }

    public async Task<List<Temperature>> GetTemperatures()
    {
        return await ReadJsonFileAsync<List<Temperature>>(_tempetarureVirtualPath);
    }

    public async Task AddTemperatures(Temperature temperature)
    {
        //  1. Leer elementos del JSon
        List<Temperature> elementos = await ReadJsonFileAsync<List<Temperature>>(_tempetarureVirtualPath);

        // 2.  Agregar nuevo elemento
        if (elementos != null)
        {
            elementos.Add(temperature);
            // 3. Escribir el nuevo Json
            await WriteJsonFileAsync(_tempetarureVirtualPath, elementos);
        }
    }

    public async Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature)
    {
        //  1. Leer elementos del JSon
        List<Temperature> elementos = temperature.ToList();

        try
        {
            await WriteJsonFileAsync(_tempetarureVirtualPath, elementos);
            return true;
        }
        catch (Exception genericException)
        {
            // Log Exception genericException.
            return false;
        };
    }

    public async Task<bool> DeleteTemperature()
    {
        //  1. Leer elementos del JSon
        List<Temperature> elementos = new();

        try 
        {
            await WriteJsonFileAsync(_tempetarureVirtualPath, elementos);
            return true;
        }
        catch (Exception genericException) 
        {
            // Log Exception genericException.
            return false;
        }        
    }

    public async Task<List<Wind>> GetWinds()
    {
=======
    }  

    public async Task<List<Temperature>> GetTemperatures()
    {
        return await ReadJsonFileAsync<List<Temperature>>(_tempetarureVirtualPath);
    }

    public async Task AddTemperatures(Temperature temperature)
    {
        //  1. Leer elementos del JSon
        List<Temperature> elementos = await ReadJsonFileAsync<List<Temperature>>(_tempetarureVirtualPath);
        
        // 2.  Agregar nuevo elemento
        if(elementos != null) 
        {   
            elementos.Add(temperature);
            // 3. Escribir el nuevo Json
            await WriteJsonFileAsync(_tempetarureVirtualPath, elementos);
        }
    }



    public async Task<List<Wind>> GetWinds()
    {
>>>>>>> d6270bd (Advilleg - Post Temperatures)
        return await ReadJsonFileAsync<List<Wind>>(_windVirtualPath);
    }

    public async Task<List<Moisture>> GetMoisture()
    {
        return await ReadJsonFileAsync<List<Moisture>>(_moistureVirtualPath);
    }
}