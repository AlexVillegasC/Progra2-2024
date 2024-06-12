using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.Models.MonitoreoClimatico;
using NLayer.Architecture.Bussines.PronosticoLluvias;
using NLayer.Architecture.Data.FileRepositories;
using NLayer.Architecture.Bussines.Services;
using NLayer.Architecture.Data;


namespace NLayer.Architecture.Bussines.Services;

public class PronosticoLluviasService : IPronosticoLluviasServices
{
    private readonly FileRepository _fileRepository;
    private readonly string _filePath = @"C:\Users\waynm\Desktop\Programacion II\NLayer.Architecture.Data\Files\lluviaLargoPlazo.json";

    private readonly IPronosticoLluviasRepository _pronosticoLluviaRepo;

    public PronosticoLluviasService(IPronosticoLluviasRepository pronosticoLluviaRepo)
    {
        _pronosticoLluviaRepo = pronosticoLluviaRepo;
    }

      public async Task<PronosticoLluvias.PronosticoLluvias> GetPronosticos()
    {
        PronosticoLluvias.PronosticoLluvias miPronostico = new PronosticoLluvias.PronosticoLluvias();

        //miPronostico.LluviaCortoPlazo = await _pronosticoLluviaRepo.GetLluviaCortoPlazos();
        //miPronostico.LluviaMedianoPlazo = await _pronosticoLluviaRepo.GetLluviaMedianoPlazos();

        miPronostico.LluviaLargoPlazo = await _pronosticoLluviaRepo.GetLluviaLargoPlazos();

        return miPronostico;
    }

    public async Task GetLluviaLargoPlazos(LluviaLargoPlazo lluviaLargoPlazo)

    {
      await _pronosticoLluviaRepo.GetLluviaLargoPlazos();
    }

    public async Task AddLluviaLargoPlazo(LluviaLargoPlazo lluviaLargoPlazo)
    {
        await _pronosticoLluviaRepo.AddLluviaLargoPlazo(lluviaLargoPlazo);
    }

    public async Task<bool> UpdateLluviaLargoPlazo(IEnumerable<LluviaLargoPlazo> lluviaLargoPlazo)
    {
        return await _pronosticoLluviaRepo.UpdateLluviaLargoPlazo(lluviaLargoPlazo);
    }

    public async Task<bool> DeleteLluviaLargoPlazo()
    {
        return await _pronosticoLluviaRepo.DeleteLluviaLargoPlazo();
    }


}



       