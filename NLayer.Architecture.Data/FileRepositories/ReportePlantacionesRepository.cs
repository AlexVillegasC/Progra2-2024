using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.GestionPlantaciones;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

public class ReportePlantacionesReposiroty : FileRepository, IReportePlantacionesRepository
{
    private string _PlagasVirtualPath = "controlplagas.json";
    //Ponen sus partes igual

    private string FolderPath { get; set; }

    public ReportePlantacionesReposiroty(IConfiguration configuration)
    {
        FolderPath = $"{configuration["Folders:Plantaciones"]}";

        _PlagasVirtualPath = FolderPath + _PlagasVirtualPath;
        //Escriben lo mismo aqui con sus partes

    }

    public async Task<ControlPlagas> GetControlPlagas()
    {
        return await ReadJsonFileAsync<ControlPlagas>(_PlagasVirtualPath);
    }

    //Creen la misma clase igual que la de arriba 














}

