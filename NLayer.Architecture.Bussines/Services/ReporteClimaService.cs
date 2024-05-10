using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.ReporteClima;

namespace NLayer.Architecture.Bussines.Services;

public class ReporteClimaService : IReporteClimaService
{
    /// </summary>
    private readonly IReporteClimaRepository _pronosticoRepo;

    public ReporteClimaService(IReporteClimaRepository pronosticoRepo)
    {
        _pronosticoRepo = pronosticoRepo;
    }

    public async Task<ReporteClima.ReporteClima> GetPronostico()
    {
        ReporteClima.ReporteClima miPronostico = new ReporteClima.ReporteClima();        
        miPronostico.Temperatura = await _pronosticoRepo.GetTemperatures();        
        miPronostico.Viento = await _pronosticoRepo.GetWinds();        
        miPronostico.Humedad = await _pronosticoRepo.GetMoisture();        

        return miPronostico;
    }

    public async Task AddTemperature(Temperature temperature)
    {
        await _pronosticoRepo.AddTemperatures(temperature);
    }
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
>>>>>>> 6b13ada (Clase 13)
=======
>>>>>>> origin/development
=======
>>>>>>> 4f0ec2d (Clase 13)
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
=======
=======
>>>>>>> 6b13ada (Clase 13)
>>>>>>> 460e175 (Clase 13)

    public async Task<bool> UpdateTemperature(IEnumerable<Temperature> temperature)
    {
        return await _pronosticoRepo.UpdateTemperature(temperature);
    }

    public async Task<bool> DeleteTemperature()
    {
        return await _pronosticoRepo.DeleteTemperature();
    }
}
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 460e175 (Clase 13)
=======
 }
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
>>>>>>> 6b13ada (Clase 13)
<<<<<<< HEAD
<<<<<<< HEAD
=======
 }
>>>>>>> 081ea19 (Advilleg - Post Temperatures)
=======
>>>>>>> 4f0ec2d (Clase 13)
=======
=======
 }
>>>>>>> d6270bd (Advilleg - Post Temperatures)
>>>>>>> 07c077a (Advilleg - Post Temperatures)
=======
>>>>>>> 460e175 (Clase 13)
=======
=======
 }
>>>>>>> d6270bd (Advilleg - Post Temperatures)
>>>>>>> a88d30b (Advilleg - Post Temperatures)
