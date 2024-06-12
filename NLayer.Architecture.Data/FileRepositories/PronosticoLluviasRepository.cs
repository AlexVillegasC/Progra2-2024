using Microsoft.Extensions.Configuration;
using System.ComponentModel.Design;
using NLayer.Architecture.Bussines.Models.MonitoreoClimatico;
using NLayer.Architecture.Data;


namespace NLayer.Architecture.Data.FileRepositories;

public class PronosticoLluviasRepository : FileRepository, IPronosticoLluviasRepository
{
    private string _lluviaLargoPlazoVirtualPath = "C:\\Users\\waynm\\Desktop\\Programacion II\\NLayer.Architecture.Data\\Files\\MonitoreoClimatico\\lluviaLargoPlazo.json";
   // private string _lluviaCortoPlazoVirtualPath = "lluviaCortoPlazo.json";
    //private string _lluviaMedianoPlazoVirtualPath = "lluviaMedianoPlazo.json";

    private string FolderPath { get; set; }

    public PronosticoLluviasRepository(IConfiguration configuration)
    {
        FolderPath = $"{configuration["Files:MonitoreoClimatico"]}";
        _lluviaLargoPlazoVirtualPath = FolderPath + _lluviaLargoPlazoVirtualPath;
 

       //_lluviaCortoPlazoVirtualPath = FolderPath + _lluviaCortoPlazoVirtualPath;
        //_lluviaMedianoPlazoVirtualPath = FolderPath + _lluviaMedianoPlazoVirtualPath;
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


    /*public async Task<LluviaCortoPlazo> GetLluviaCortoPlazos()
    {
        return await ReadJsonFileAsync<LluviaCortoPlazo>(_lluviaCortoPlazoVirtualPath);
    }

    public async Task<LluviaMedianoPlazo> GetLluviaMedianoPlazos()
    {
        return await ReadJsonFileAsync<LluviaMedianoPlazo>(_lluviaMedianoPlazoVirtualPath);
    }
    */
}
