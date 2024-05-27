using NLayer.Architecture.Bussines.Models.TheSillies;

namespace DataAccess.Layer.FileRepositories;

public interface ICostosHigieneRepository
{
    Task<List<CostosHigiene>> GetCostosHigiene();
    Task<CostosAlimenticios> GetCostosAlimenticios();
    Task AddCostosHigiene(CostosHigiene costosHigiene);
}