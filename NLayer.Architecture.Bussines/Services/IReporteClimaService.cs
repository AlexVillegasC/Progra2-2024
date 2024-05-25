using NLayer.Architecture.Bussines.ReporteClima;

namespace NLayer.Architecture.Bussines.Services;


public interface IReporteClimaService
{
    Task<ReporteClima.ReporteClima> GetPronostico();
    Task AddTemperature(Temperature temperature);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);
    Task<bool> DeleteTemperature();
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);
    Task<bool> DeleteTemperature();
>>>>>>> 6b13ada (Clase 13)
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);
    Task<bool> DeleteTemperature();
>>>>>>> 6b13ada (Clase 13)
=======
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);
    Task<bool> DeleteTemperature();
>>>>>>> origin/development
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);
    Task<bool> DeleteTemperature();
>>>>>>> 6b13ada (Clase 13)
}
