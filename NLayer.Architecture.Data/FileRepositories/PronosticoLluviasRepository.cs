using Microsoft.Extensions.Configuration;
using System.ComponentModel.Design;
using NLayer.Architecture.Bussines.Models.MonitoreoClimatico;
using NLayer.Architecture.Data;


namespace NLayer.Architecture.Data.FileRepositories;

public class PronosticoLluviasRepository : FileRepository, IPronosticoLluviasRepository
{
    private string _lluviaLargoPlazoVirtualPath = "lluviaLargoPlazo.json";
    private string _lluviaLargoCortoPlazoVirtualPath = "lluviaCortoPlazo.json";
    private string _lluviaCortoPlazoVirtualPath;

    private string FolderPath { get; set; }

    public PronosticoLluviasRepository(IConfiguration configuration)
    {
        FolderPath = $"{configuration["Folders:MonitoreoClimatico"]}";
        _lluviaLargoPlazoVirtualPath = FolderPath + _lluviaLargoPlazoVirtualPath;
        _lluviaLargoCortoPlazoVirtualPath = FolderPath + _lluviaLargoCortoPlazoVirtualPath;
    }
    public async Task<LluviaLargoPlazo> GetLluviaLargoPlazos()
    {
        return await ReadJsonFileAsync<LluviaLargoPlazo>(_lluviaLargoPlazoVirtualPath);
    }

    public async Task<LluviaCortoPlazo> GetLluviaCortoPlazos()
    {
        return await ReadJsonFileAsync<LluviaCortoPlazo>(_lluviaCortoPlazoVirtualPath);
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

