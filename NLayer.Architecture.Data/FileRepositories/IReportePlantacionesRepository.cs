using NLayer.Architecture.Bussines.GestionPlantaciones;


namespace DataAccess.Layer.FileRepositories;

public interface IReportePlantacionesRepository
{

    //-------------PLAGAS----------------------------------//
    Task<List<ControlPlagas>> GetControlPlagas();  //GET PLAGAS
    Task AddPlaga(ControlPlagas plagas);  //POST PLAGAS
    Task<bool> UpdatePlaga(IEnumerable<ControlPlagas> plagas);  //PUT PLAGAS
    Task<bool> DeletePlaga(); //DELETE PLAGAS
    //-------------PLAGAS----------------------------------//


    //-------------ABONO----------------------------------//
    Task<List<ControlAbono>> GetControlAbono();
    Task<bool> UpdateControlAbono(IEnumerable<ControlAbono> abono);
    Task AddControlAbono(ControlAbono abono);
    Task<bool> DeleteControlAbono();
    //-------------ABONO----------------------------------//


    Task<ArbolFrutal> GetArbolFrutal();
}

