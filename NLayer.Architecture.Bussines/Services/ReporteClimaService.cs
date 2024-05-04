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
        await _pronosticoRepo.AddTemperature(temperature);
    }
}
