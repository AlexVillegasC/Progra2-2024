using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.GestionPlantaciones;

namespace NLayer.Architecture.Bussines.Services;

public class ReportePlantaciones : IReportePlantaciones
{
    private readonly IReportePlantacionesRepository _plantaciones;

    public ReportePlantaciones(IReportePlantacionesRepository plantaciones)
    {
        _plantaciones = plantaciones;
    }

    public async Task<GestionPlantaciones.GestionPlantaciones> GetReporte()
    {
        GestionPlantaciones.GestionPlantaciones reporteArbol = new GestionPlantaciones.GestionPlantaciones();
        reporteArbol.Plagas = await _plantaciones.GetControlPlagas();
        reporteArbol.Abono = await _plantaciones.GetControlAbono();
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();

        return reporteArbol;
    }

    //-------------ABONO--------------------------------//
    public async Task AddControlAbono(ControlAbono abono)
    {
        await _plantaciones.AddControlAbono(abono);
    }

    public async Task<bool> UpdateControlAbono(IEnumerable<ControlAbono> abono)
    {
        return await _plantaciones.UpdateControlAbono(abono);
    }

    public async Task<bool> DeleteControlAbono()
    {
        return await _plantaciones.DeleteControlAbono();
    }

    public Task<List<ControlAbono>> GetControlAbono() 
    {
        throw new NotImplementedException();
    }

    //-------------ABONO----------------------------------//


    //-------------PLAGAS----------------------------------//

    public async Task AddPlaga(ControlPlagas plagas)  //POST PLAGAS
    {
        await _plantaciones.AddPlaga(plagas);
    }

    public async Task<bool> UpdatePlaga(IEnumerable<ControlPlagas> plagas) //PUT PLAGAS
    {
        return await _plantaciones.UpdatePlaga(plagas);
    }

    public async Task<bool> DeletePlaga()  //DELETE PLAGAS
    {
        return await _plantaciones.DeletePlaga();
    }

    //-------------PLAGAS----------------------------------//


    //-------------ARBOL----------------------------------//
   / public async Task AddArbolFrutal(ArbolFrutal arbolFrutal)
    {
        await _plantaciones.AddArbolFrutal(arbolFrutal);
    }

    public async Task<bool> UpdateArbolFrutal(IEnumerable<ArbolFrutal> arbolFrutal)
    {
        return await _plantaciones.UpdateArbolFrutal(arbolFrutal);
    }

    public async Task<bool> DeleteArbolFrutal()
    {
        return await _plantaciones.DeleteArbolFrutal();
    }
    //-------------ARBOL----------------------------------//
}