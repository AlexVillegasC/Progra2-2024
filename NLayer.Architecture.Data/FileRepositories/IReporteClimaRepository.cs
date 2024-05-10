using NLayer.Architecture.Bussines.ReporteClima;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteClimaRepository
{
    Task<List<Temperature>> GetTemperatures();
    Task AddTemperatures(Temperature temperature);

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 6b13ada (Clase 13)
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);

    Task<bool> DeleteTemperature();

    Task<List<Wind>> GetWinds();

=======
    Task<List<Wind>> GetWinds();

>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
    Task<List<Wind>> GetWinds();

>>>>>>> d6270bd (Advilleg - Post Temperatures)
    Task<List<Moisture>> GetMoisture();
}