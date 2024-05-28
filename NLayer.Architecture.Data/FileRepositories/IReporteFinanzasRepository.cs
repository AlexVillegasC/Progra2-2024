using NLayer.Architecture.Bussines.Models.TheSillies;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteFinanzasRepository
{
    Task<List<CostosHigiene>> GetCostosHigiene();
    Task<List<CostosAlimenticios>> GetCostosAlimenticios();
    Task<List<CostosMedicina>> GetCostosMedicina();
    Task AddCostosHigiene(CostosHigiene costosHigiene);

    Task <bool>UpdateCostosHigiene(IEnumerable<CostosHigiene> costoHigiene);

    Task<bool> DeleteCostosHigiene();

    Task AddCostosAlimentos(CostosAlimenticios costosAlimenticios);

    Task<bool> UpdateCostoAlimento(IEnumerable<CostosAlimenticios> costoAlimento);

    Task<bool> DeleteCostosAlimenticios();
    Task AddCostosMedicina(CostosMedicina costosMedicina);

    Task<bool> UpdateCostoMedicina(IEnumerable<CostosMedicina> costoMedicina);

    Task<bool> DeleteCostosMedicina();

}