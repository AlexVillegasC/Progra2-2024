using NLayer.Architecture.Bussines.GestionPlantaciones;


namespace DataAccess.Layer.FileRepositories;

public interface IReportePlantacionesRepository
{






















    Task<List<ControlPlagas>> GetControlPlagas();  //GET PLAGAS
    Task AddPlaga(ControlPlagas plagas);  //POST PLAGAS
    Task<bool> UpdatePlaga(IEnumerable<ControlPlagas> plagas);  //PUT PLAGAS
    Task<bool> DeletePlaga(); //DELETE PLAGAS


    Task<List<ControlAbono>> GetControlAbono();
    Task<bool> UpdateControlAbono(IEnumerable<ControlAbono> abono);
    Task AddControlAbono(ControlAbono abono);
    Task<bool> DeleteControlAbono();
  


    Task<ArbolFrutal> GetArbolFrutal();
}

