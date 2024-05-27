using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.Models.TheSillies;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

public class CostosHigieneRepository : FileRepository, ICostosHigieneRepository
{
    private string _HigieneVirtualPath = "CostosHigiene.json";

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
    private string folderPath {  get; set; }

    public CostosHigieneRepository(IConfiguration Configuration)
    {
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
    }

    public async Task<List<CostosHigiene>> GetCostosHigiene()
    {
        return await ReadJsonFileAsync<List<CostosHigiene>>(_HigieneVirtualPath);
    }
    public async Task<CostosAlimenticios> GetCostosAlimenticios()
    {
        return await ReadJsonFileAsync<CostosAlimenticios>(_AlimenticiosVirtualPath);
    }

    public async Task AddCostosHigiene (CostosHigiene costosHigiene)
    {
        List<CostosHigiene> elements = await ReadJsonFileAsync<List<CostosHigiene>>(_HigieneVirtualPath);

        if (elements != null)
        {
            elements.Add(costosHigiene);
            await WriteJsonFileAsync(_HigieneVirtualPath, elements);
        }
    }
}