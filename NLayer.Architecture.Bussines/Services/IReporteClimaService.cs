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
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);
    Task<bool> DeleteTemperature();
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
<<<<<<< HEAD
=======
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);
    Task<bool> DeleteTemperature();
>>>>>>> 6b13ada (Clase 13)
=======
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);
    Task<bool> DeleteTemperature();
>>>>>>> origin/development
=======
>>>>>>> 081ea19 (Advilleg - Post Temperatures)
=======
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);
    Task<bool> DeleteTemperature();
>>>>>>> 4f0ec2d (Clase 13)
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
}
