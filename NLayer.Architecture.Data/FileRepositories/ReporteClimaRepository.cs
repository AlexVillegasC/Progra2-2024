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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 4f0ec2d (Clase 13)
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
=======
>>>>>>> 460e175 (Clase 13)
=======
>>>>>>> a88d30b (Advilleg - Post Temperatures)
=======
=======
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> 5d63356 (Advilleg - Post Temperatures)
=======
=======
>>>>>>> 6b13ada (Clase 13)
>>>>>>> 26f959d (Clase 13)
=======
>>>>>>> 6b13ada (Clase 13)
>>>>>>> 739f4a7 (Clase 13)
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
<<<<<<< HEAD
<<<<<<< HEAD

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
=======
>>>>>>> 081ea19 (Advilleg - Post Temperatures)
    }  
=======
    }
>>>>>>> 6b13ada (Clase 13)

    public async Task<List<Temperature>> GetTemperatures()
    {
        return await ReadJsonFileAsync<List<Temperature>>(_tempetarureVirtualPath);
    }

    public async Task AddTemperatures(Temperature temperature)
    {
        //  1. Leer elementos del JSon
        List<Temperature> elementos = await ReadJsonFileAsync<List<Temperature>>(_tempetarureVirtualPath);
<<<<<<< HEAD

        // 2.  Agregar nuevo elemento
        if (elementos != null)
        {
=======
        
        // 2.  Agregar nuevo elemento
        if(elementos != null) 
        {   
>>>>>>> 081ea19 (Advilleg - Post Temperatures)
            elementos.Add(temperature);
            // 3. Escribir el nuevo Json
            await WriteJsonFileAsync(_tempetarureVirtualPath, elementos);
        }
    }

<<<<<<< HEAD
    public async Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature)
    {
        //  1. Leer elementos del JSon
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
>>>>>>> origin/development
        List<Temperature> elementos = temperature.ToList();
=======
>>>>>>> 739f4a7 (Clase 13)

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
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
>>>>>>> origin/development
=======
=======
>>>>>>> 4f0ec2d (Clase 13)

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
>>>>>>> 081ea19 (Advilleg - Post Temperatures)
=======
=======
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
    }  
=======
    }
>>>>>>> 6b13ada (Clase 13)

    public async Task<List<Temperature>> GetTemperatures()
    {
        return await ReadJsonFileAsync<List<Temperature>>(_tempetarureVirtualPath);
    }

    public async Task AddTemperatures(Temperature temperature)
    {
        //  1. Leer elementos del JSon
        List<Temperature> elementos = await ReadJsonFileAsync<List<Temperature>>(_tempetarureVirtualPath);
<<<<<<< HEAD
<<<<<<< HEAD

        // 2.  Agregar nuevo elemento
        if (elementos != null)
        {
=======
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
        
        // 2.  Agregar nuevo elemento
        if(elementos != null) 
        {   
<<<<<<< HEAD
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
            elementos.Add(temperature);
            // 3. Escribir el nuevo Json
            await WriteJsonFileAsync(_tempetarureVirtualPath, elementos);
        }
    }

<<<<<<< HEAD
<<<<<<< HEAD
    public async Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature)
    {
        //  1. Leer elementos del JSon
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
>>>>>>> origin/development
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
<<<<<<< HEAD
>>>>>>> d6270bd (Advilleg - Post Temperatures)
<<<<<<< HEAD
>>>>>>> 07c077a (Advilleg - Post Temperatures)
=======
=======
=======
>>>>>>> 6b13ada (Clase 13)

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
>>>>>>> d6270bd (Advilleg - Post Temperatures)
<<<<<<< HEAD
>>>>>>> a88d30b (Advilleg - Post Temperatures)
=======
=======
>>>>>>> origin/development
<<<<<<< HEAD
>>>>>>> f932598 (Squashed commit of the following:)
=======
=======
=======
>>>>>>> 6b13ada (Clase 13)

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
>>>>>>> d6270bd (Advilleg - Post Temperatures)
>>>>>>> 5d63356 (Advilleg - Post Temperatures)
        return await ReadJsonFileAsync<List<Wind>>(_windVirtualPath);
    }

    public async Task<List<Moisture>> GetMoisture()
    {
        return await ReadJsonFileAsync<List<Moisture>>(_moistureVirtualPath);
    }
}