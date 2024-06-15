namespace NLayer.Architecture.Bussines.Services;

public interface IReportePlantaciones
{
    Task<GestionPlantaciones.GestionPlantaciones> GetReporte();
}
