using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.GestionPlantaciones;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

public class ReportePlantacionesRepository : FileRepository, IReportePlantacionesRepository
{
    private string _PlagasVirtualPath = @"C:\Users\alond\source\repos\Progra2-2024\NLayer.Architecture.Data\Files\Plantaciones\controlplagas.json";
    //Ponen sus partes igual
    private string _AbonoVirtualPath = @"C:\Users\alond\source\repos\Progra2-2024\NLayer.Architecture.Data\Files\Plantaciones\ControlAbono.json";

    private string FolderPath { get; set; }


    public ReportePlantacionesRepository (IConfiguration Configuration)
    {
        FolderPath = $"{Configuration["Folders:Plantaciones"]}";

        _PlagasVirtualPath = FolderPath + _PlagasVirtualPath;
        //Escriben lo mismo aqui con sus partes
        _AbonoVirtualPath = FolderPath + _AbonoVirtualPath;

    }

    public async Task<ControlPlagas> GetControlPlagas()
    {
        return await ReadJsonFileAsync<ControlPlagas>(_PlagasVirtualPath);
    }
    
    public async Task<ControlAbono> GetControlAbono() //mostrar los datos 
    {
        return await ReadJsonFileAsync<ControlAbono>(_AbonoVirtualPath);
    }

    //Creen la misma clase igual que la de arriba 


   
}

