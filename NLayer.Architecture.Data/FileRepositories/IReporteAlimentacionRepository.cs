using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Bussines.ReporteAlimentacion;
using NLayer.Architecture.Bussines.ReporteClima;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteAlimentacionRepository
{
    Task<Trabajadores> GetTrabajadores();
    Task<List<Animales>> GetAnimales();
    Task<List<Alimentos>> GetAlimentos();
    Task AddAlimentos(Alimentos alimentos);
    Task AddTrabajadores(Trabajadores trabajadores);
    Task<bool> UpdateAlimento(IEnumerable<Alimentos>alimentos);
    Task<bool> UpdateAnimales(IEnumerable<Animales> animales);
    Task<bool> DeleteAlimentos();


}
