using NLayer.Architecture.Bussines.GestionPlantaciones;
using NLayer.Architecture.Bussines.GestionPlantaciones;

namespace DataAccess.Layer.FileRepositories;

public interface IReportePlantacionesRepository
{
    Task<ControlPlagas> GetControlPlagas();

    //Sus Partes.... igual que arriba 

    Task<ControlAbono> GetControlAbono();


    Task<ArbolFrutal> GetArbolFrutal();
}

