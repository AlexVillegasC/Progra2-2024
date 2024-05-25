using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

public class ReporteAlimentacionRepository : FileRepository, IReporteAlimentacionRepository
{
    private string _trabajadoresVirtualPath = "Trabajadores.json";
    private string _AnimalesVirtualPath = "Animales.json";
    private string _AlimentosVirtualPath = "Alimentos.json";

    private string FolderPath { get; set; }

    public ReporteAlimentacionRepository(IConfiguration Configuration)
    {
        FolderPath = $"{Configuration["Folders:Alimentacion_Nutricion"]}";
        _trabajadoresVirtualPath = FolderPath + _trabajadoresVirtualPath;
        _AnimalesVirtualPath = FolderPath + _AnimalesVirtualPath;
        _AlimentosVirtualPath = FolderPath + _AlimentosVirtualPath;
    }
    public async Task<List<Trabajadores>> GetTrabajadores()
    {
        return await ReadListJsonAsync<Trabajadores>(_trabajadoresVirtualPath);
    }

    public async Task<List<Animales>> GetAnimales()
    {
        return await ReadListJsonAsync<Animales>(_AnimalesVirtualPath);

    }

    public async Task<List<Alimentos>> GetAlimentos()
    {
        return await ReadListJsonAsync<Alimentos>(_AlimentosVirtualPath);
    }
    public async Task AddAlimentos(Alimentos alimentos)
    {

        List<Alimentos> elementos = await ReadJsonFileAsync<List<Alimentos>>(_AlimentosVirtualPath);


        if (elementos != null)
        {
            elementos.Add(alimentos);

            await WriteJsonFileAsync(_AlimentosVirtualPath, elementos);
        }
    }
    public async Task<bool> UpdateAlimento(IEnumerable<Alimentos> alimentos)
    {

        List<Alimentos> elementos = alimentos.ToList();
        try
        {
            await WriteJsonFileAsync(_AlimentosVirtualPath, elementos);
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }

    public async Task<bool> DeleteAlimentos()
    {
        //  1. Leer elementos del JSon
        List<Alimentos> elementos = new();

        try
        {
            await WriteJsonFileAsync(_AlimentosVirtualPath, elementos);
            return true;
        }

        catch (Exception genericException)
        {
            // Log Exception genericException.
            return false;
        }
    }
    public async Task AddWorkers(Trabajadores trabajadores)
    {
        List<Trabajadores> elementos = await ReadJsonFileAsync<List<Trabajadores>>(_trabajadoresVirtualPath);
        if (elementos != null)
        {
            elementos.Add(trabajadores);
            await WriteJsonFileAsync(_trabajadoresVirtualPath, elementos);

        }

    }
}
