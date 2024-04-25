using DataAccess.Layer.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;

public class ReporteClimaService : IReporteClimaService
{


    /// </summary>
    private readonly IReporteClimaRepository _pronosticoRepo;

    public ReporteClimaService(
       ReporteClimaRepository pronosticoRepo)
    {
        _pronosticoRepo = pronosticoRepo;
    }

    public async Task<ReporteClima.ReporteClima> GetPronostico(int type)
    {
        ReporteClima.ReporteClima miPronostico = new ReporteClima.ReporteClima();
        miPronostico.Viento = await _pronosticoRepo.GetWinds();
        miPronostico.Temperatura = await _pronosticoRepo.GetTemperatures();
        miPronostico.Humedad = await _pronosticoRepo.GetMoisture();

        return miPronostico;
    }
}
