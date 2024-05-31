using NLayer.Architecture.Data;
using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.ReporteInventarioRecursos;


namespace DataAccess.Layer.FileRepositories;
public class ReporteInventarioRecursosRepository : FileRepository, IReporteInventarioRecursosRepository
{
    private string FertilizantesVirtualPath = "Fertilizantes.json";
    private string PesticidasVirtualPath = "Pesticidas.json";



    private string FolderPath { get; set; }


    public ReporteInventarioRecursosRepository(IConfiguration configuration)
    {
        FolderPath = $"{configuration["Folders:Recursos"]}";
        FertilizantesVirtualPath = FolderPath + FertilizantesVirtualPath;
        PesticidasVirtualPath = FolderPath + PesticidasVirtualPath;

    }

    public async Task<Fertilizantes> GetFertilizantes()
    {
        return await ReadJsonFileAsync<Fertilizantes>(FertilizantesVirtualPath);
    }

    public async Task<Pesticidas> GetPesticidas()
    {
        return await ReadJsonFileAsync<Pesticidas>(PesticidasVirtualPath);
    }
}