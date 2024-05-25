using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteAlimentacionRepository
{
    Task<List<Trabajadores>> GetTrabajadores();
    Task<List<Animales>> GetAnimales();
    Task<List<Alimentos>> GetAlimentos();
    Task AddAlimentos(Alimentos alimentos);
    Task AddAnimals(Animales animales);
    Task<bool> UpdateAlimento(IEnumerable<Alimentos>alimentos);
    Task<bool> DeleteAlimentos();
    Task<bool> DeleteAnimals();   

    


}
