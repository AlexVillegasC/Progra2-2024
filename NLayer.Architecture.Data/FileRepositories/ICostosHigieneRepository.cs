using NLayer.Architecture.Bussines.Models.The_Sillies;

namespace DataAccess.Layer.FileRepositories;

public interface ICostosHigieneRepository
{
    Task<CostosHigiene> GetCostosHigiene();
}