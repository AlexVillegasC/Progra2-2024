using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.Models.TheSillies;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Data;
using System.ComponentModel.Design;

namespace DataAccess.Layer.FileRepositories;

public class ReporteFinanzasRepository : FileRepository, IReporteFinanzasRepository
{
    private string _HigieneVirtualPath = "CostosHigiene.json";

    private string _AlimenticiosVirtualPath = "CostosAlimenticios.json";
    private string folderPath {  get; set; }

    public ReporteFinanzasRepository(IConfiguration Configuration)
    {
        folderPath = $"{Configuration["Folders:TheSillies"]}";
        _HigieneVirtualPath = folderPath + _HigieneVirtualPath;
        _AlimenticiosVirtualPath = folderPath + _AlimenticiosVirtualPath;
    }

    public async Task<List<CostosHigiene>> GetCostosHigiene()
    {
        return await ReadJsonFileAsync<List<CostosHigiene>>(_HigieneVirtualPath);
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

    public async Task<bool> UpdateCostosHigiene(IEnumerable<CostosHigiene> costoHigiene)
    {
        List<CostosHigiene> elements = costoHigiene.ToList();
        try
        {
            await WriteJsonFileAsync(_HigieneVirtualPath, elements);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public async Task<bool> DeleteCostosHigiene()
    {
        List<CostosHigiene> elements = new();
        try
        {
            await WriteJsonFileAsync(_HigieneVirtualPath, elements);
            return true;
        }
        catch (Exception ex) 
        { 
            return false; 
        }
    }

    public async Task<List<CostosAlimenticios>> GetCostosAlimenticios()
    {
        return await ReadJsonFileAsync<List<CostosAlimenticios>>(_AlimenticiosVirtualPath);
    }

    public async Task AddCostosAlimentos(CostosAlimenticios costosAlimenticios)
    {
        List<CostosAlimenticios> elements = await ReadJsonFileAsync<List<CostosAlimenticios>>(_AlimenticiosVirtualPath);

        if (elements != null)
        {
            elements.Add(costosAlimenticios);
            await WriteJsonFileAsync(_AlimenticiosVirtualPath, elements);
        }
    }

    public async Task<bool> UpdateCostoAlimento(IEnumerable<CostosAlimenticios> costoAlimento)
    {
        //  1. Leer elementos del JSon
        List<CostosAlimenticios> elementos = costoAlimento.ToList();

        try
        {
            await WriteJsonFileAsync(_AlimenticiosVirtualPath, elementos);
            return true;
        }
        catch (Exception genericException)
        {
            // Log Exception genericException.
            return false;
        };
    }
    public async Task<bool> DeleteCostosAlimenticios()
    {
        //  1. Leer elementos del JSon
        List<CostosAlimenticios> elementos = new();

        try
        {
            await WriteJsonFileAsync(_AlimenticiosVirtualPath, elementos);
            return true;
        }
        catch (Exception genericException)
        {
            // Log Exception genericException.
            return false;
        }
    }
}