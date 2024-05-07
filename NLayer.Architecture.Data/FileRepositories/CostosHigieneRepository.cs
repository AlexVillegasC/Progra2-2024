using Microsoft.Extensions.Configuration;
<<<<<<< HEAD
using NLayer.Architecture.Bussines.Models.TheSillies;
=======
using NLayer.Architecture.Bussines.Models.The_Sillies;
>>>>>>> 1672b8f (costos higiene)
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

public class CostosHigieneRepository : FileRepository, ICostosHigieneRepository
{
    private string _HigieneVirtualPath = "CostosHigiene.json";
<<<<<<< HEAD

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
=======
>>>>>>> 1672b8f (costos higiene)
    private string folderPath {  get; set; }

    public CostosHigieneRepository(IConfiguration Configuration)
    {
<<<<<<< HEAD
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
=======
        folderPath = $"{Configuration["Folders:CostosGenerales"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
>>>>>>> 1672b8f (costos higiene)
    }

    public async Task<CostosHigiene> GetCostosHigiene()
    {
        return await ReadJsonFileAsync<CostosHigiene>(_HigieneVirtualPath);
    }
<<<<<<< HEAD
    public async Task<CostosAlimenticios> GetCostosAlimenticios()
    {
        return await ReadJsonFileAsync<CostosAlimenticios>(_AlimenticiosVirtualPath);
    }
=======
>>>>>>> 1672b8f (costos higiene)
}