using DataAccess.Layer.FileRepositories;

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

        return miPronostico;
    }
}
