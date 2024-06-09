using NLayer.Architecture.Bussines.GestionPlantaciones;

namespace NLayer.Architecture.Bussines.Services;

public interface IReportePlantaciones
{
    //-------------PLAGAS----------------------------------//
    Task<GestionPlantaciones.GestionPlantaciones> GetReporte();  //GET PLAGAS
    Task AddPlaga(ControlPlagas plagas); //POST  PLAGAS
    Task<bool> UpdatePlaga(IEnumerable<ControlPlagas> plagas);  //PUT PLAGAS
    Task<bool> DeletePlaga();   //DELETE PLAGAS
    //-------------PLAGAS----------------------------------//

    //-------------ABONO----------------------------------//
    Task<List<ControlAbono>> GetControlAbono();
    Task AddControlAbono(ControlAbono abono);
    Task<bool> UpdateControlAbono(IEnumerable<ControlAbono> abono);
    Task<bool> DeleteControlAbono();

    //-------------ABONO----------------------------------//

    //-------------ARBOL----------------------------------//
    Task<List<ArbolFrutal>> GetArbolFrutal();
    Task<bool> UpdateArbolFrutal(IEnumerable<ArbolFrutal> arbol);
    Task<bool> DeleteArbolFrutal();
    Task AddArbolFrutal(ArbolFrutal arbol);
    //-------------ARBOL----------------------------------//

}
