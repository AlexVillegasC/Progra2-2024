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
}
