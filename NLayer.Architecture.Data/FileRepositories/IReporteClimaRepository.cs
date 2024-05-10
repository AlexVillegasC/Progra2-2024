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
=======
>>>>>>> 6b13ada (Clase 13)
=======
>>>>>>> origin/development
=======
>>>>>>> 4f0ec2d (Clase 13)
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);

    Task<bool> DeleteTemperature();

    Task<List<Wind>> GetWinds();

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
=======
    Task<List<Wind>> GetWinds();

>>>>>>> d6270bd (Advilleg - Post Temperatures)
<<<<<<< HEAD
=======
>>>>>>> origin/development
=======
    Task<List<Wind>> GetWinds();

>>>>>>> 081ea19 (Advilleg - Post Temperatures)
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
    Task<List<Moisture>> GetMoisture();
}