using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.GestionRiego;
using NLayer.Architecture.Data.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;

public class GestionRiegoService : IGestionRiegoService
{
    /// </summary>
    private readonly IGestorRiego _estadoRiegoRepo;

    public GestionRiegoService(IGestorRiego estadoRiegoRepo)
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
