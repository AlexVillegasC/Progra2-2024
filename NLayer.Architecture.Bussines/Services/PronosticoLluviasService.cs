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
    //private readonly string _filePath = @"C:\Users\waynm\Desktop\Programacion II\NLayer.Architecture.Data\Files\lluviaLargoPlazo.json";
    private readonly string _filePath = @"C:\Users\SoporteCruxTDC\Pictures\JOHANA\NLayer.Architecture.Data\Files\lluviaMedianoPlazo.json";
    private readonly IPronosticoLluviasRepository _pronosticoLluviaRepo;

    public PronosticoLluviasService(IPronosticoLluviasRepository pronosticoLluviaRepo)
    {
        _pronosticoLluviaRepo = pronosticoLluviaRepo;
    }

      public async Task<PronosticoLluvias.PronosticoLluvias> GetPronosticos()
    {
        PronosticoLluvias.PronosticoLluvias miPronostico = new PronosticoLluvias.PronosticoLluvias();

        //miPronostico.LluviaCortoPlazo = await _pronosticoLluviaRepo.GetLluviaCortoPlazos();
        miPronostico.LluviaMedianoPlazo = await _pronosticoLluviaRepo.GetLluviaMedianoPlazos();
        miPronostico.LluviaLargoPlazo = await _pronosticoLluviaRepo.GetLluviaLargoPlazos();

        return miPronostico;
    }

    public async Task GetLluviaMedianoPlazos(LluviaMedianoPlazo lluviaMedianoPlazo)
    {
        await _pronosticoLluviaRepo.GetLluviaMedianoPlazos();
    }
    
    public async Task AddLluviaMedianoPlazo(LluviaMedianoPlazo lluviaMedianoPlazo)
    {
        await _pronosticoLluviaRepo.AddLluviaMedianoPlazo(lluviaMedianoPlazo);
    }

    public async Task<bool> UpdateLluviaMedianoPlazo(IEnumerable<LluviaMedianoPlazo> lluviaMedianoPlazo)
    {
        return await _pronosticoLluviaRepo.UpdateLluviaMedianoPlazo(lluviaMedianoPlazo);
    }

    public async Task<bool> DeleteLluviaMedianoPlazo()
    {
        return await _pronosticoLluviaRepo.DeleteLluviaMedianoPlazo();
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



       