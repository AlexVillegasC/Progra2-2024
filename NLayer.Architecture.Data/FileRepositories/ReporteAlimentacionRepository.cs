using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

 public class ReporteAlimentacionRepository : FileRepository, IReporteAlimentacionRepository
{
    private string _trabajadoresVirtualPath = "Trabajadores.json";
    private string _AnimalesVirtualPath = "Animales.json";





    private string FolderPath { get; set; }

    public ReporteAlimentacionRepository(IConfiguration Configuration)
    {
        FolderPath = $"{Configuration["Folders: Alimentacion_Nutricion"]}";
        _trabajadoresVirtualPath = FolderPath + _trabajadoresVirtualPath;
        _AnimalesVirtualPath = FolderPath + _AnimalesVirtualPath;
    }
    public async Task<Trabajadores> GetTrabajadores()
    {
        return await ReadJsonFileAsync<Trabajadores>(_trabajadoresVirtualPath);
    }

    public async Task<List<Animales>> GetAnimales()
    {
        return await ReadListJsonAsync<Animales>(_AnimalesVirtualPath);

    }

}
