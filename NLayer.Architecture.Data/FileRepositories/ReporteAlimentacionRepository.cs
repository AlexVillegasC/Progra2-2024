using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

public class ReporteAlimentacionRepository : FileRepository, IReporteAlimentacionRepository
{
    private string _trabajadoresVirtualPath = @"C:\Users\obalt\source\repos\Progra2-2024\NLayer.Architecture.Data\Files\Alimentacion_Nutricion\Trabajadores.json";
    private string _AnimalesVirtualPath = @"C:\Users\obalt\source\repos\Progra2-2024\NLayer.Architecture.Data\Files\Alimentacion_Nutricion\Animales.json";
    private string _AlimentosVirtualPath = @"C:\Users\obalt\source\repos\Progra2-2024\NLayer.Architecture.Data\Files\Alimentacion_Nutricion\Alimentos.json";

    private string FolderPath { get; set; }

    public ReporteAlimentacionRepository(IConfiguration Configuration)
    {
        FolderPath = $"{Configuration["Folders:Alimentacion_Nutricion"]}";
        _trabajadoresVirtualPath = FolderPath + _trabajadoresVirtualPath;
        _AnimalesVirtualPath = FolderPath + _AnimalesVirtualPath;
        _AlimentosVirtualPath = FolderPath + _AlimentosVirtualPath;
    }
    public async Task<Trabajadores> GetTrabajadores()
    {
        return await ReadJsonFileAsync<Trabajadores>(_trabajadoresVirtualPath);
    }

    public async Task<List<Animales>> GetAnimales()
    {
        return await ReadListJsonAsync<Animales>(_AnimalesVirtualPath);

    }

    public async Task<List<Alimentos>> GetAlimentos()
    {
        return await ReadListJsonAsync<Alimentos>(_AlimentosVirtualPath);
    }
}
