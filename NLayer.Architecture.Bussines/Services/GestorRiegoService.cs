using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.Models.Cultivo;
using NLayer.Architecture.Data.FileRepositories;
using IGestorRiegoRepository = NLayer.Architecture.Data.FileRepositories.IGestorRiegoRepository;

namespace NLayer.Architecture.Bussines.Services;

public class GestorRiegoService : IGestorRiegoService
{
    /// </summary>
    private readonly IGestorRiegoRepository _estadoRiegoRepo;

    public GestorRiegoService(IGestorRiegoRepository estadoRiegoRepo)
    {
        _estadoRiegoRepo = estadoRiegoRepo;
    }

    public async Task<GestionRiego.GestionRiego> GetEstadoRiego()
    {
        GestionRiego.GestionRiego miEstadoRiego = new GestionRiego.GestionRiego();        
        miEstadoRiego.Temperatura = await _estadoRiegoRepo.GetTemperatures();
        miEstadoRiego.Humedad = await _estadoRiegoRepo.GetMoisture();
        miEstadoRiego.Cultivo = await _estadoRiegoRepo.GetCultivo();

        return miEstadoRiego;
    }
}
