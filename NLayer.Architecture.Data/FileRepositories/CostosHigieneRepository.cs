﻿using Microsoft.Extensions.Configuration;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 011c04a (costos higiene)
using NLayer.Architecture.Bussines.Models.TheSillies;
=======
using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
=======
using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> origin/development
=======
using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> b5fa883 (costos higiene)
=======
using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
>>>>>>> 011c04a (costos higiene)
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

public class CostosHigieneRepository : FileRepository, ICostosHigieneRepository
{
    private string _HigieneVirtualPath = "CostosHigiene.json";
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 011c04a (costos higiene)

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
=======
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
=======

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
>>>>>>> origin/development
=======
>>>>>>> b5fa883 (costos higiene)
=======

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
>>>>>>> 011c04a (costos higiene)
    private string folderPath {  get; set; }

    public CostosHigieneRepository(IConfiguration Configuration)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 011c04a (costos higiene)
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
=======
        folderPath = $"{Configuration["Folders:CostosGenerales"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
=======
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
>>>>>>> origin/development
=======
        folderPath = $"{Configuration["Folders:CostosGenerales"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
>>>>>>> b5fa883 (costos higiene)
=======
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
>>>>>>> 011c04a (costos higiene)
    }

    public async Task<CostosHigiene> GetCostosHigiene()
    {
        return await ReadJsonFileAsync<CostosHigiene>(_HigieneVirtualPath);
    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
>>>>>>> origin/development
=======
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
>>>>>>> 011c04a (costos higiene)
    public async Task<CostosAlimenticios> GetCostosAlimenticios()
    {
        return await ReadJsonFileAsync<CostosAlimenticios>(_AlimenticiosVirtualPath);
    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 1672b8f (costos higiene)
=======
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
>>>>>>> origin/development
=======
>>>>>>> b5fa883 (costos higiene)
=======
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
=======
>>>>>>> 1672b8f (costos higiene)
>>>>>>> 011c04a (costos higiene)
}