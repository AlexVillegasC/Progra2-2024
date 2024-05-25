using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Bussines.ReporteAlimentacion;
using NLayer.Architecture.Bussines.ReporteClima;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteAlimentacionRepository
{
    Task<List<Trabajadores>> GetTrabajadores();
    Task<List<Animales>> GetAnimales();
    Task<List<Alimentos>> GetAlimentos();
    Task AddAlimentos(Alimentos alimentos);
    Task<bool> UpdateAlimento(IEnumerable<Alimentos>alimentos);
    Task<bool> DeleteAlimentos();
    Task AddWorkers(Trabajadores trabajadores);


}
