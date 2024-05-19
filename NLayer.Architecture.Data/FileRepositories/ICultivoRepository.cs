using NLayer.Architecture.Bussines.GestionCultivo;

namespace DataAccess.Layer.FileRepositories;


public interface ICultivoRepository
{
    Task<GestionCultivo> GetGestionCultivo();

    Task<CoeficienteCultivo> GetCoeficienteCultivo();

    Task<CultivoDatos> GetCultivoDatos();

    Task<Reservorio> GetReservorio();


}