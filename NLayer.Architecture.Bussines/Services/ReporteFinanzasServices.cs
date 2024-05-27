using DataAccess.Layer.FileRepositories;
using Newtonsoft.Json.Bson;
using NLayer.Architecture.Bussines.Models.TheSillies;

namespace NLayer.Architecture.Bussines.Services;

public class ReporteFinanzasServices : IReporteFinanzasServices
{
    private readonly IReporteFinanzasRepository _FinanzasRepository;

    public ReporteFinanzasServices(IReporteFinanzasRepository costosHigieneRepository)
    {
        _FinanzasRepository = costosHigieneRepository;
    }

    public async Task<TheSillies.CostosGenerales> GetCostosGenerales()
    {
        TheSillies.CostosGenerales reporteHigiene = new TheSillies.CostosGenerales();
        reporteHigiene.CostosHigiene = await _FinanzasRepository.GetCostosHigiene();
        reporteHigiene.CostosAlimenticios = await _FinanzasRepository.GetCostosAlimenticios();

        return reporteHigiene;
    }

    public async Task AddCostosHigiene (CostosHigiene costosHigiene)
    {
        await _FinanzasRepository.AddCostosHigiene(costosHigiene);
    }

    public async Task<bool> UpdateCostosHigiene (IEnumerable<CostosHigiene> costos)
    {
        return await _FinanzasRepository.UpdateCostosHigiene(costos);
    }

    public async Task<bool> DeleteCostosHigiene()
    {
        return await _FinanzasRepository.DeleteCostosHigiene ();
    }

    public async Task AddCostosAlimentos(CostosAlimenticios costosAlimenticios)
    {
        await _FinanzasRepository.AddCostosAlimentos(costosAlimenticios);
    }

    public async Task<bool> UpdateCostoAlimento(IEnumerable<CostosAlimenticios> costoAlimento)
    {
        return await _FinanzasRepository.UpdateCostoAlimento(costoAlimento);
    }

    public async Task<bool> DeleteCostosAlimenticios()
    {
        return await _FinanzasRepository.DeleteCostosAlimenticios();
    }
}