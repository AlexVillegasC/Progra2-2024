using NLayer.Architecture.Bussines.GestionPlantaciones;
using NLayer.Architecture.Bussines.GestionPlantaciones;

namespace DataAccess.Layer.FileRepositories;

public interface IReportePlantacionesRepository
{
    Task<ControlPlagas> GetControlPlagas();
    Task<ArbolFrutal> GetArbolFrutal();


    Task<List<ControlAbono>> GetControlAbono();
    Task<bool> UpdateControlAbono(IEnumerable<ControlAbono> abono);
    Task AddControlAbono(ControlAbono abono);
    Task<bool> DeleteControlAbono();
  

    
}

