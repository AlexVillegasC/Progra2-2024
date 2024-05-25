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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> a88d30b (Advilleg - Post Temperatures)
=======
=======
>>>>>>> 5d63356 (Advilleg - Post Temperatures)
=======
>>>>>>> 26f959d (Clase 13)
=======
>>>>>>> 6b13ada (Clase 13)
>>>>>>> 739f4a7 (Clase 13)
=======
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> 6b13ada (Clase 13)
=======
>>>>>>> origin/development
=======
<<<<<<< HEAD
>>>>>>> 4f0ec2d (Clase 13)
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
=======
=======
>>>>>>> 6b13ada (Clase 13)
<<<<<<< HEAD
>>>>>>> 460e175 (Clase 13)
=======
=======
>>>>>>> origin/development
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> 6b13ada (Clase 13)
>>>>>>> 26f959d (Clase 13)
    Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature);

    Task<bool> DeleteTemperature();

    Task<List<Wind>> GetWinds();

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
=======
>>>>>>> f932598 (Squashed commit of the following:)
=======
    Task<List<Wind>> GetWinds();

>>>>>>> d6270bd (Advilleg - Post Temperatures)
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> origin/development
=======
    Task<List<Wind>> GetWinds();

<<<<<<< HEAD
>>>>>>> 081ea19 (Advilleg - Post Temperatures)
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
=======
=======
    Task<List<Wind>> GetWinds();

>>>>>>> d6270bd (Advilleg - Post Temperatures)
<<<<<<< HEAD
>>>>>>> a88d30b (Advilleg - Post Temperatures)
=======
=======
>>>>>>> origin/development
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
>>>>>>> 5d63356 (Advilleg - Post Temperatures)
    Task<List<Moisture>> GetMoisture();
}