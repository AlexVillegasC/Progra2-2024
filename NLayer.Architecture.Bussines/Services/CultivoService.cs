using DataAccess.Layer.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;


public class CultivoService : ICultivoService
{
    private readonly ICultivoRepository _cultivoRepository;

    public CultivoService(ICultivoRepository cultivoRepository)
    {
        _cultivoRepository = cultivoRepository;
    }

    public async Task<GestionCultivo.GestionCultivo> GetCultivo()
    {
        GestionCultivo.GestionCultivo miCultivo = new GestionCultivo.GestionCultivo();
        miCultivo.CultivoDatos = await _cultivoRepository.GetCultivoDatos();
        miCultivo.CoeficienteCultivo = await _cultivoRepository.GetCoeficienteCultivo();
        miCultivo.Reservorio = await _cultivoRepository.GetReservorio();


        return miCultivo;
    }
}