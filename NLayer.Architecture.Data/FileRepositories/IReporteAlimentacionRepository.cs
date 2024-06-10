using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Bussines.Models.RegistroGanado;
namespace DataAccess.Layer.FileRepositories;

public interface IReporteAlimentacionRepository
{
    Task<Trabajadores> GetTrabajadores();
    Task<List<Animales>> GetAnimales();
    Task<List<Alimentos>> GetAlimentos();

    Task AddGanado (Ganado ganado);
    Task <bool> UpdateGanado (IEnumerable<Ganado> ganado);
    Task <bool> DeleteGanado (); 

}
