using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.Models.The_Sillies;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

public class CostosHigieneRepository : FileRepository, ICostosHigieneRepository
{
    private string _HigieneVirtualPath = "CostosHigiene.json";
    private string folderPath {  get; set; }

    public CostosHigieneRepository(IConfiguration Configuration)
    {
        folderPath = $"{Configuration["Folders:CostosGenerales"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
    }

    public async Task<CostosHigiene> GetCostosHigiene()
    {
        return await ReadJsonFileAsync<CostosHigiene>(_HigieneVirtualPath);
    }
}