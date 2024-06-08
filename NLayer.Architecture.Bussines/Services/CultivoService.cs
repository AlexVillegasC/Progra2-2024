using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.GestionCultivo;

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

    public async Task AddCultivos(GestionCultivo.GestionCultivo cultivo)
    {
        await _cultivoRepository.AddGestionCultivo(cultivo);
    }
    public async Task<bool> UpdateCultivo(IEnumerable<GestionCultivo.GestionCultivo> cultivo)
    {
        return await _cultivoRepository.UpdateGestionCultivo(cultivo);
    }
    public async Task DeleteCultivo()
    {
        await _cultivoRepository.DeleteGestionCultivo();
    }

    public async Task AddCultivoDatos(CultivoDatos cultivoDatos)
    {
        await _cultivoRepository.AddCultivoDatos(cultivoDatos);
    }
    public async Task<bool> UpdateCultivoDatos(IEnumerable<CultivoDatos> cultivoDatos)
    {
        return await _cultivoRepository.UpdateCultivoDatos(cultivoDatos);
    }
    public async Task DeleteCultivoDatos()
    {
        await _cultivoRepository.DeleteCultivo();
    }

    public async Task AddReservorio(Reservorio reservorio)
    {
        await _cultivoRepository.AddReservorio(reservorio);
    }
    public async Task<bool> UpdateReservorio(IEnumerable<Reservorio> reservorio)
    {
        return await _cultivoRepository.UpdateReservorio(reservorio);
    }
    public async Task DeleteReservorio()
    {
        await _cultivoRepository.DeleteReservorio();
    }

    public async Task AddCoeficienteCultivo(CoeficienteCultivo coeficienteCultivo)
    {
        await _cultivoRepository.AddCoeficienteCultivo(coeficienteCultivo);
    }
    public async Task<bool> UpdateCoeficienteCultivo(IEnumerable<CoeficienteCultivo> coeficienteCultivo)
    {
        return await _cultivoRepository.UpdateCoeficienteCultivo(coeficienteCultivo);
    }
    public async Task DeleteCoeficienteCultivo()
    {
        await _cultivoRepository.DeleteCoeficienteCultivo();
    }

}