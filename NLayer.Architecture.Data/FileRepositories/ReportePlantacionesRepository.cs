<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 818cb8c (Proyecto casi finalizado)
﻿using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.GestionPlantaciones;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;
<<<<<<< HEAD

namespace DataAccess.Layer.FileRepositories;

public class ReportePlantacionesRepository : FileRepository, IReportePlantacionesRepository
{
    private string _PlagasVirtualPath = "controlplagas.json";
    //Ponen sus partes igual
    private string _AbonoVirtualPath = "ControlAbono.json";
    private string _ArbolVirtualPath = "ArbolFrutal.json";

    private string FolderPath { get; set; }


    public ReportePlantacionesRepository(IConfiguration Configuration)
    {
        FolderPath = $"{Configuration["Folders:Plantaciones"]}";

        _PlagasVirtualPath = FolderPath + _PlagasVirtualPath;
        //Escriben lo mismo aqui con sus partes
        _AbonoVirtualPath = FolderPath + _AbonoVirtualPath;
        _ArbolVirtualPath = FolderPath + _ArbolVirtualPath;

    }

    public async Task<ControlPlagas> GetControlPlagas()
    {
        return await ReadJsonFileAsync<ControlPlagas>(_PlagasVirtualPath);
    }

    public async Task<ControlAbono> GetControlAbono() //mostrar los datos 
    {
        return await ReadJsonFileAsync<ControlAbono>(_AbonoVirtualPath);
    }

    public async Task<ArbolFrutal> GetArbolFrutal()
    {
        return await ReadJsonFileAsync<ArbolFrutal>(_ArbolVirtualPath);
    }

    //Creen la misma clase igual que la de arriba 


   
}

=======
=======
>>>>>>> cbb4e73 (Carpeta y 2 clases nuevas)
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
>>>>>>> 818cb8c (Proyecto casi finalizado)

namespace DataAccess.Layer.FileRepositories;

public class ReportePlantacionesRepository : FileRepository, IReportePlantacionesRepository
{
    private string _PlagasVirtualPath = "controlplagas.json";
    //Ponen sus partes igual
    private string _AbonoVirtualPath = "ControlAbono.json";
    private string _ArbolVirtualPath = "ArbolFrutal.json";

    private string FolderPath { get; set; }


    public ReportePlantacionesRepository(IConfiguration Configuration)
    {
        FolderPath = $"{Configuration["Folders:Plantaciones"]}";

        _PlagasVirtualPath = FolderPath + _PlagasVirtualPath;
        //Escriben lo mismo aqui con sus partes
        _AbonoVirtualPath = FolderPath + _AbonoVirtualPath;
        _ArbolVirtualPath = FolderPath + _ArbolVirtualPath;

    }

    public async Task<ControlPlagas> GetControlPlagas()
    {
        return await ReadJsonFileAsync<ControlPlagas>(_PlagasVirtualPath);
    }

    public async Task<ControlAbono> GetControlAbono() //mostrar los datos 
    {
        return await ReadJsonFileAsync<ControlAbono>(_AbonoVirtualPath);
    }

    public async Task<ArbolFrutal> GetArbolFrutal()
    {
        return await ReadJsonFileAsync<ArbolFrutal>(_ArbolVirtualPath);
    }

    //Creen la misma clase igual que la de arriba 


   
}
<<<<<<< HEAD
>>>>>>> cbb4e73 (Carpeta y 2 clases nuevas)
=======

>>>>>>> 818cb8c (Proyecto casi finalizado)
=======

namespace NLayer.Architecture.Data.FileRepositories
{
    internal class ReportePlantacionesRepository
    {
    }
}
>>>>>>> cbb4e73 (Carpeta y 2 clases nuevas)
