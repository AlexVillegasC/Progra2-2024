using NLayer.Architecture.Bussines.GestionPlantaciones;


namespace DataAccess.Layer.FileRepositories;

public interface IReportePlantacionesRepository
{






















    Task<List<ControlPlagas>> GetControlPlagas();  //GET PLAGAS
    Task AddPlaga(ControlPlagas plagas);  //POST PLAGAS
    Task<bool> UpdatePlaga(IEnumerable<ControlPlagas> plagas);  //PUT PLAGAS
    Task<bool> DeletePlaga(); //DELETE PLAGAS



    Task<ControlAbono> GetControlAbono();
    Task<ArbolFrutal> GetArbolFrutal();
}

