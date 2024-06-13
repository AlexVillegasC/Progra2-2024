using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.Models.MonitoreoClimatico;
using NLayer.Architecture.Bussines.PronosticoLluvias;
using NLayer.Architecture.Data.FileRepositories;
using NLayer.Architecture.Bussines.Services;


namespace NLayer.Architecture.Bussines.Services;

public class PronosticoLluviasService : IPronosticoLluviasServices
{
    private readonly IPronosticoLluviasRepository _pronosticoLluviaRepo;

    public PronosticoLluviasService(IPronosticoLluviasRepository pronosticoLluviaRepo)
    {
        _pronosticoLluviaRepo = pronosticoLluviaRepo;
    }

      public async Task<PronosticoLluvias.PronosticoLluvias> GetPronosticos()
    {
        PronosticoLluvias.PronosticoLluvias miPronostico = new PronosticoLluvias.PronosticoLluvias();
        miPronostico.LluviaCortoPlazo = await _pronosticoLluviaRepo.GetLluviaCortoPlazos();
        miPronostico.LluviaLargoPlazo = await _pronosticoLluviaRepo.GetLluviaLargoPlazos();

        return miPronostico;
    }

   public async Task GetLluviaCortoPlazos(LluviaCortoPlazo lluviaCortoPlazo)
    {
        await _pronosticoLluviaRepo.GetLluviaCortoPlazos();
    }

    public async Task AddLluviaCortoPlazo(LluviaCortoPlazo lluviaCortoPlazo)
    {
        await _pronosticoLluviaRepo.AddLluviaCortoPlazo(lluviaCortoPlazo);
    }

    public async Task<bool> UpdateLluviaCortoPlazo(IEnumerable<LluviaCortoPlazo> lluviaCortoPlazo)
    {
        return await _pronosticoLluviaRepo.UpdateLluviaCortoPlazo(lluviaCortoPlazo);
    }

    public async Task<bool> DeleteLluviaCortoPlazo()
    {
        return await _pronosticoLluviaRepo.DeleteLluviaCortoPlazo();
    }
}



       