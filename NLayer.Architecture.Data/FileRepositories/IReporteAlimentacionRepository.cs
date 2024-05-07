using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
namespace DataAccess.Layer.FileRepositories;

public interface IReporteAlimentacionRepository
{
    Task<Trabajadores> GetTrabajadores();
    Task<List<Animales>> GetAnimales();
    Task<List<Alimentos>> GetAlimentos();
}
