using NLayer.Architecture.Bussines.GestionPlantaciones;

namespace NLayer.Architecture.Bussines.Services;

public interface IReportePlantaciones
{
    Task<GestionPlantaciones.GestionPlantaciones> GetReporte();  //GET PLAGAS
    Task AddPlaga(ControlPlagas plagas); //POST  PLAGAS
    Task<bool> UpdatePlaga(IEnumerable<ControlPlagas> plagas);  //PUT PLAGAS
    Task<bool> DeletePlaga();   //DELETE PLAGAS
}
