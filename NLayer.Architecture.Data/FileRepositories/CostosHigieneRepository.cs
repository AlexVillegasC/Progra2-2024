using Microsoft.Extensions.Configuration;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using NLayer.Architecture.Bussines.Models.TheSillies;
=======
using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> 1672b8f (costos higiene)
=======
using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> 1672b8f (costos higiene)
=======
using NLayer.Architecture.Bussines.Models.TheSillies;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
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

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
=======
>>>>>>> 1672b8f (costos higiene)
=======

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
>>>>>>> 1672b8f (costos higiene)
=======

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
    private string folderPath {  get; set; }

    public CostosHigieneRepository(IConfiguration Configuration)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
=======
        folderPath = $"{Configuration["Folders:CostosGenerales"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
>>>>>>> 1672b8f (costos higiene)
=======
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
        folderPath = $"{Configuration["Folders:CostosGenerales"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
>>>>>>> 1672b8f (costos higiene)
=======
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
    }

    public async Task<CostosHigiene> GetCostosHigiene()
    {
        return await ReadJsonFileAsync<CostosHigiene>(_HigieneVirtualPath);
    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
    public async Task<CostosAlimenticios> GetCostosAlimenticios()
    {
        return await ReadJsonFileAsync<CostosAlimenticios>(_AlimenticiosVirtualPath);
    }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 1672b8f (costos higiene)
=======
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
=======
>>>>>>> 1672b8f (costos higiene)
=======
>>>>>>> 0ecaee0 (Cambios de CostosAlimenticios)
}