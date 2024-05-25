using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteAlimentacionRepository
{
    Task<List<Trabajadores>> GetTrabajadores();
    Task<List<Animales>> GetAnimales();
    Task<List<Alimentos>> GetAlimentos();
    Task AddAlimentos(Alimentos alimentos);
    Task AddAnimals(Animales animals);
    Task AddTrabajadores(Trabajadores trabajadores);
    Task<bool> UpdateAlimento(IEnumerable<Alimentos>alimentos);
    Task<bool> UpdateAnimales(IEnumerable<Animales> animales);
    Task<bool> DeleteAlimentos();
    Task<bool> DeleteAnimals();   

    


}
