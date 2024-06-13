using NLayer.Architecture.Data;
using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.ReporteInventarioRecursos;
using NLayer.Architecture.Bussines.ReporteClima;


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

public async Task AddFertilizantes(Fertilizantes fertilizantes)
{
    List<Fertilizantes> elemento = await ReadJsonFileAsync<List<Fertilizantes>>(FertilizantesVirtualPath);

    if (elemento != null)
    {
        elemento.Add(fertilizantes);

        await WriteJsonFileAsync(FertilizantesVirtualPath, elemento);
    }
}



public async Task<bool> UpdateFertilizantes(IEnumerable<Fertilizantes> fertilizantes)
{
    List<Fertilizantes> elementos = fertilizantes.ToList();

    try
    {
        await WriteJsonFileAsync(FertilizantesVirtualPath, elementos);
        return true;
    }
    catch (Exception genericException)
    {
        return false;
    }
}

public async Task<bool> DeleteFertilizantes()
{
    List<Fertilizantes> elementos = new();

    try
    {
     
        await WriteJsonFileAsync(FertilizantesVirtualPath, elementos);
        return true;

    }
    catch (Exception genericException)
    {
        return false;
    }

}





public async Task<List<Pesticidas>> GetPesticidas()
{
    return await ReadJsonFileAsync<List<Pesticidas>>(PesticidasVirtualPath);
}


public async Task AddPesticidas(Pesticidas pesticidas)
{
    List<Pesticidas> elemento = await ReadJsonFileAsync<List<Pesticidas>>(PesticidasVirtualPath);

    if (elemento != null)
    {
        elemento.Add(pesticidas);

        await WriteJsonFileAsync(PesticidasVirtualPath, elemento);
    }
}


public async Task<bool> UpdatePesticidas(IEnumerable<Pesticidas> pesticidas)
{
    List<Pesticidas> elementos = pesticidas.ToList();

    try
    {
        await WriteJsonFileAsync(PesticidasVirtualPath, elementos);
        return true;
    }
    catch (Exception genericException)
    {
        return false;
    }

}


public async Task<bool> DeletePesticidas()
{
    List<Pesticidas> elementos = new();

    try
    {
        await WriteJsonFileAsync(PesticidasVirtualPath, elementos);
        return true;
    }
    catch (Exception genericException)
    {
        return false;
    }


}

} 
//Esteban pasar por este 
