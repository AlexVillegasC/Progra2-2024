using NLayer.Architecture.Bussines.GestionCultivo;

namespace DataAccess.Layer.FileRepositories;


public interface ICultivoRepository
{
    Task<List<GestionCultivo>> GetGestionCultivo();

    Task<List<CoeficienteCultivo>> GetCoeficienteCultivo();

    Task<List<CultivoDatos>> GetCultivoDatos();

    Task<List<Reservorio>> GetReservorio();

    Task AddGestionCultivo(GestionCultivo gestionCultivo);

    Task<bool> UpdateGestionCultivo(IEnumerable<GestionCultivo> gestionCultivo);

    Task <bool> DeleteGestionCultivo();

    Task AddCultivoDatos(CultivoDatos cultivoDatos);
    Task<bool> UpdateCultivoDatos(IEnumerable<CultivoDatos> cultivoDatos);

    Task<bool> DeleteCultivo();

    Task AddReservorio(Reservorio reservorio);
    Task<bool> UpdateReservorio(IEnumerable<Reservorio> reservorio);
    Task<bool> DeleteReservorio();

    Task AddCoeficienteCultivo(CoeficienteCultivo coeficienteCultivo);
    Task<bool> UpdateCoeficienteCultivo(IEnumerable<CoeficienteCultivo> coeficienteCultivo);
    Task<bool> DeleteCoeficienteCultivo();
}