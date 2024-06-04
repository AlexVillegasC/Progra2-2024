using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.GestionPlantaciones;
using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Bussines.ReporteClima;
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



    public async Task<ArbolFrutal> GetArbolFrutal()
    {
        return await ReadJsonFileAsync<ArbolFrutal>(_ArbolVirtualPath);
    }

  
    //-----------------------------------------------------------------------------------//

    public async Task<List<ControlAbono>> GetControlAbono() //mostrar los datos 
    {
        return await ReadJsonFileAsync<List<ControlAbono>>(_AbonoVirtualPath);
    }


    public async Task AddControlAbono(ControlAbono abono)
    {
        List<ControlAbono> ab = await ReadJsonFileAsync<List<ControlAbono>>(_AbonoVirtualPath);
        if (ab != null)
        {
            ab.Add(abono);
            await WriteJsonFileAsync(_AbonoVirtualPath, ab);
        }
    }


    public async Task<bool> UpdateControlAbono(IEnumerable<ControlAbono> abono)
    {
        
        List<ControlAbono> ab = abono.ToList();

        try
        {
            await WriteJsonFileAsync(_AbonoVirtualPath, ab);
            return true;
        }
        catch (Exception genericException)
        {
          
            return false;
        };
    }

    public async Task<bool> DeleteControlAbono() 
    {

        List<ControlAbono> ab= new();

        try
        {
            await WriteJsonFileAsync(_AbonoVirtualPath, ab);
            return true;
        }
        catch (Exception genericException)
        {
            return false;
        }
    }
 

   
}

