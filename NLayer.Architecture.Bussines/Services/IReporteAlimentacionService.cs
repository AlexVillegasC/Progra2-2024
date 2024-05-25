
using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Bussines.ReporteAlimentacion;


namespace NLayer.Architecture.Bussines.Services;

public interface IReporteAlimentacionService
{



    Task AddAlimentos(Alimentos alimentos);
    Task AddTrabajadores(Trabajadores trabajadores);
    Task AddAnimals(Animales animals);
    Task<Produccion> GetProduccion();
    Task<bool>UpdateAlimento(IEnumerable<Alimentos> alimentos);
    Task<bool> UpdateAnimales(IEnumerable<Animales> animales);
    Task<bool> DeleteAlimentos();
    Task<bool> DeleteAnimals();

}
