using NLayer.Architecture.Bussines.GestionCultivo;

namespace NLayer.Architecture.Bussines.Services;

public interface ICultivoService
{
    Task<GestionCultivo.GestionCultivo> GetCultivo();

    Task AddCultivos(GestionCultivo.GestionCultivo cultivo);

    Task<bool> UpdateCultivo(IEnumerable<GestionCultivo.GestionCultivo> cultivo);
    Task DeleteCultivo();

    Task AddCultivoDatos(CultivoDatos cultivoDatos);
    Task<bool> UpdateCultivoDatos(IEnumerable<CultivoDatos> cultivoDatos);
    Task DeleteCultivoDatos();

    Task AddReservorio(Reservorio reservorio);
    Task<bool> UpdateReservorio(IEnumerable<Reservorio> reservorio);
    Task DeleteReservorio();

    Task AddCoeficienteCultivo(CoeficienteCultivo coeficienteCultivo);
    Task<bool> UpdateCoeficienteCultivo(IEnumerable<CoeficienteCultivo> coeficienteCultivo);
    Task DeleteCoeficienteCultivo();
}