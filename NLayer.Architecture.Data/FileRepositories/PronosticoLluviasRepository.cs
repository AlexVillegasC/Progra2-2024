using Microsoft.Extensions.Configuration;
using System.ComponentModel.Design;
using NLayer.Architecture.Bussines.Models.MonitoreoClimatico;
using NLayer.Architecture.Data;
using System.Linq.Expressions;


namespace NLayer.Architecture.Data.FileRepositories;

public class PronosticoLluviasRepository : FileRepository, IPronosticoLluviasRepository 
{
    
    private string _lluviaLargoPlazoVirtualPath = "lluviaLargoPlazo.json";
    private string _lluviaCortoPlazoVirtualPath = "lluviaCortoPlazo.json";
    private string _lluviaMedianoPlazoVirtualPath = "lluviaMedianoPlazo.json";

    private string FolderPath { get; set; }

    public PronosticoLluviasRepository(IConfiguration configuration)
    {
        FolderPath = $"{configuration["Files:MonitoreoClimatico"]}";
        _lluviaLargoPlazoVirtualPath = FolderPath + _lluviaLargoPlazoVirtualPath;
        _lluviaCortoPlazoVirtualPath = FolderPath + _lluviaCortoPlazoVirtualPath;
        _lluviaMedianoPlazoVirtualPath = FolderPath + _lluviaMedianoPlazoVirtualPath;



    }
    public async Task<List<LluviaLargoPlazo>> GetLluviaLargoPlazos()
    {
        return await ReadJsonFileAsync<List<LluviaLargoPlazo>>(_lluviaLargoPlazoVirtualPath);
    }

    public async Task AddLluviaLargoPlazo(LluviaLargoPlazo lluviaLargoPlazo)
    {
        List<LluviaLargoPlazo> elementos = await ReadJsonFileAsync<List<LluviaLargoPlazo>>(_lluviaLargoPlazoVirtualPath);
        if (elementos != null)
        {
            elementos.Add(lluviaLargoPlazo);
            await WriteJsonFileAsync(_lluviaLargoPlazoVirtualPath, elementos);
        }
    }

    public async Task<bool> UpdateLluviaLargoPlazo(IEnumerable<LluviaLargoPlazo> lluviaLargoPlazos)
    {
        List<LluviaLargoPlazo> elementos = lluviaLargoPlazos.ToList();

        try
        {
            await WriteJsonFileAsync(_lluviaLargoPlazoVirtualPath, elementos);
            return true;
        }
        catch (Exception genericException)

        {
            return false;
        }

    }

    public async Task<bool> DeleteLluviaLargoPlazo()
    {
        List<LluviaLargoPlazo> elementos = new();

        try
        {
            await WriteJsonFileAsync(_lluviaLargoPlazoVirtualPath, elementos);
            return true;
        }
        catch (Exception genericException)

        {
            return false;
        }

    }




    public async Task<List<LluviaCortoPlazo>> GetLluviaCortoPlazo()
    {
        return await ReadJsonFileAsync<List<LluviaCortoPlazo>>(_lluviaCortoPlazoVirtualPath);
    }

    public async Task AddLluviaCortoPlazo(LluviaCortoPlazo lluviaCortoPlazo)
    {
        List<LluviaCortoPlazo> elementos = await ReadJsonFileAsync<List<LluviaCortoPlazo>>(_lluviaCortoPlazoVirtualPath);
        if (elementos != null)
        {
            elementos.Add(lluviaCortoPlazo);
            await WriteJsonFileAsync(_lluviaCortoPlazoVirtualPath, elementos);
        }
    }

    public async Task<bool> UpdateLluviaCortoPlazo(IEnumerable<LluviaCortoPlazo> lluviaCortoPlazos)
    {
        List<LluviaCortoPlazo> elementos = lluviaCortoPlazos.ToList();

        try
        {
            await WriteJsonFileAsync(_lluviaCortoPlazoVirtualPath, elementos);
            return true;
        }

        catch (Exception genericException)

        {
            return false;
        }
    }

    public async Task<bool> DeleteLluviaCortoPlazo()
    {
        List<LluviaCortoPlazo> elementos = new();

        try
        {
            await WriteJsonFileAsync(_lluviaCortoPlazoVirtualPath, elementos);
            return true;
        }

        catch (Exception generincException)

        {
            return false;
        }
    }
}
    public async Task<List<LluviaMedianoPlazo>>GetLluviaMedianoPlazos()
   {
       return await ReadJsonFileAsync<List<LluviaMedianoPlazo>>(_lluviaMedianoPlazoVirtualPath);
   }

   public async Task AddLluviaMedianoPlazo(LluviaMedianoPlazo lluviaMedianoPlazo)
   {
       List<LluviaMedianoPlazo> elementos = await ReadJsonFileAsync<List<LluviaMedianoPlazo>>(_lluviaMedianoPlazoVirtualPath);
       if (elementos != null)
       {
           elementos.Add(lluviaMedianoPlazo);
           await WriteJsonFileAsync(_lluviaMedianoPlazoVirtualPath, elementos);
       }
   }

   public async Task<bool> UpdateLluviaMedianoPlazo(IEnumerable<LluviaMedianoPlazo> lluviaMedianoPlazos)
   {
       List<LluviaMedianoPlazo> elementos = lluviaMedianoPlazos.ToList();

       try
       {
           await WriteJsonFileAsync(_lluviaMedianoPlazoVirtualPath, elementos);
           return true;
       }

       catch (Exception genericException)

       {
           return false;
       }
   }

   public async Task<bool> DeleteLluviaMedianoPlazo()
   {
       List<LluviaLargoPlazo> elementos = new();

       try
       {
           await WriteJsonFileAsync(_lluviaMedianoPlazoVirtualPath, elementos);
           return true;
       }

       catch (Exception generincException)

       {
           return false;
       }
    }
}

