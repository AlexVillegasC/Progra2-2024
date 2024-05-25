using NLayer.Architecture.Bussines.ReporteClima;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteClimaRepository
{
    Task<List<Temperature>> GetTemperatures();
    Task AddTemperatures(Temperature temperature);

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 6b13ada (Clase 13)
=======
>>>>>>> 6b13ada (Clase 13)
=======
>>>>>>> origin/development
=======
>>>>>>> 6b13ada (Clase 13)
=======
>>>>>>> origin/development
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);

    Task<bool> DeleteTemperature();

    Task<List<Wind>> GetWinds();

<<<<<<< HEAD
<<<<<<< HEAD
=======
    Task<List<Wind>> GetWinds();

>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
    Task<List<Wind>> GetWinds();

>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
>>>>>>> origin/development
=======
    Task<List<Wind>> GetWinds();

>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
>>>>>>> origin/development
    Task<List<Moisture>> GetMoisture();
}