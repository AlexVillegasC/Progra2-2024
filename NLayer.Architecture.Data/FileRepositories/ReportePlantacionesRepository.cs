using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.GestionPlantaciones;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

public class ReportePlantacionesRepository : FileRepository, IReportePlantacionesRepository
{
    private string _PlagasVirtualPath = "controlplagas.json";
    private string _AbonoVirtualPath = "ControlAbono.json";
    private string _ArbolVirtualPath = "ArbolFrutal.json";

    private string FolderPath { get; set; }


    public ReportePlantacionesRepository(IConfiguration Configuration)
    {
        FolderPath = $"{Configuration["Folders:Plantaciones"]}";

        _PlagasVirtualPath = FolderPath + _PlagasVirtualPath;
        _AbonoVirtualPath = FolderPath + _AbonoVirtualPath;
        _ArbolVirtualPath = FolderPath + _ArbolVirtualPath;

    }

































































    //-------------------------------------------------------------------------//
    public async Task<List<ControlPlagas>> GetControlPlagas()
    {
        return await ReadJsonFileAsync<List<ControlPlagas>>(_PlagasVirtualPath);
    }

    public async Task AddPlaga(ControlPlagas plagas)
    {
        List<ControlPlagas> control = await ReadJsonFileAsync<List<ControlPlagas>>(_PlagasVirtualPath);

        if (control != null)
        {
            control.Add(plagas);
            await WriteJsonFileAsync(_PlagasVirtualPath, control);
        }
    }

    public async Task<bool> UpdatePlaga(IEnumerable<ControlPlagas> plagas)
    {
        List<ControlPlagas> control = plagas.ToList();

        try
        {
            await WriteJsonFileAsync(_PlagasVirtualPath, control);
            return true;
        }
        catch (Exception genericException)
        {
            return false;
        }
    }

    public async Task<bool> DeletePlaga()
    {
        List<ControlPlagas> control = new();

        try
        {
            await WriteJsonFileAsync(_PlagasVirtualPath, control);
            return true;
        }
        catch (Exception genericException)
        {
            return false;
        }
    }
    //---------------------------------------------------------------//



    public async Task<ControlAbono> GetControlAbono() //Mostrar los datos 
    {
        return await ReadJsonFileAsync<ControlAbono>(_AbonoVirtualPath);
    }

    public async Task<ArbolFrutal> GetArbolFrutal()
    {
        return await ReadJsonFileAsync<ArbolFrutal>(_ArbolVirtualPath);
    }

 


   
}

