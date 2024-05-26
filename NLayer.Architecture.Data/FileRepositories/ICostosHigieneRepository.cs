using NLayer.Architecture.Bussines.Models.TheSillies;

namespace DataAccess.Layer.FileRepositories;

public interface ICostosHigieneRepository
{
    Task<CostosHigiene> GetCostosHigiene();
    Task<List<CostosAlimenticios>> GetCostosAlimenticios();
    Task<bool> DeleteCostoAlimenticio();

}