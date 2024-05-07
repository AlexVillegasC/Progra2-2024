using Microsoft.Extensions.Configuration;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 011c04a (costos higiene)
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
>>>>>>> 3fc5f46 (costos higiene)
=======
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
=======
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> 809dc53 (costos higiene)
using NLayer.Architecture.Bussines.Models.TheSillies;
=======
using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
<<<<<<< HEAD
=======
using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
<<<<<<< HEAD
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
=======
=======
using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
>>>>>>> 3fc5f46 (costos higiene)
=======
=======
using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
<<<<<<< HEAD
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
=======
=======
using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> origin/development
<<<<<<< HEAD
>>>>>>> f932598 (Squashed commit of the following:)
=======
=======
using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> 1672b8f (costos higiene)
>>>>>>> 809dc53 (costos higiene)
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 011c04a (costos higiene)
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
>>>>>>> 3fc5f46 (costos higiene)
=======
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
=======
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> 809dc53 (costos higiene)

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
=======
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
<<<<<<< HEAD
<<<<<<< HEAD
=======

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
>>>>>>> origin/development
=======
<<<<<<< HEAD
>>>>>>> b5fa883 (costos higiene)
=======

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
>>>>>>> 011c04a (costos higiene)
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
=======
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
>>>>>>> 3fc5f46 (costos higiene)
=======
=======

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
<<<<<<< HEAD
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
=======
=======

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
>>>>>>> origin/development
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> 1672b8f (costos higiene)
>>>>>>> 809dc53 (costos higiene)
    private string folderPath {  get; set; }

    public CostosHigieneRepository(IConfiguration Configuration)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 011c04a (costos higiene)
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
>>>>>>> 3fc5f46 (costos higiene)
=======
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
=======
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> 809dc53 (costos higiene)
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
=======
        folderPath = $"{Configuration["Folders:CostosGenerales"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
<<<<<<< HEAD
<<<<<<< HEAD
=======
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
>>>>>>> origin/development
=======
        folderPath = $"{Configuration["Folders:CostosGenerales"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
<<<<<<< HEAD
>>>>>>> b5fa883 (costos higiene)
=======
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
>>>>>>> 011c04a (costos higiene)
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
=======
        folderPath = $"{Configuration["Folders:CostosGenerales"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
>>>>>>> 3fc5f46 (costos higiene)
=======
=======
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
<<<<<<< HEAD
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
=======
=======
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
>>>>>>> origin/development
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> 1672b8f (costos higiene)
>>>>>>> 809dc53 (costos higiene)
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 3fc5f46 (costos higiene)
=======
=======
>>>>>>> 809dc53 (costos higiene)
=======
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
=======
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
>>>>>>> origin/development
=======
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
>>>>>>> 011c04a (costos higiene)
=======
=======
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
<<<<<<< HEAD
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
=======
>>>>>>> origin/development
>>>>>>> f932598 (Squashed commit of the following:)
    public async Task<CostosAlimenticios> GetCostosAlimenticios()
    {
        return await ReadJsonFileAsync<CostosAlimenticios>(_AlimenticiosVirtualPath);
    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
=======
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> 1672b8f (costos higiene)
=======
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> origin/development
=======
<<<<<<< HEAD
>>>>>>> b5fa883 (costos higiene)
=======
>>>>>>> cb3d41d (Cambios de CostosAlimenticios)
=======
=======
>>>>>>> 1672b8f (costos higiene)
<<<<<<< HEAD
>>>>>>> 011c04a (costos higiene)
=======
>>>>>>> 327ae84 (Cambios de CostosAlimenticios)
=======
=======
>>>>>>> 1672b8f (costos higiene)
>>>>>>> 3fc5f46 (costos higiene)
=======
=======
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
<<<<<<< HEAD
>>>>>>> 6e78fa3 (Cambios de CostosAlimenticios)
=======
=======
>>>>>>> origin/development
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> 1672b8f (costos higiene)
>>>>>>> 809dc53 (costos higiene)
}