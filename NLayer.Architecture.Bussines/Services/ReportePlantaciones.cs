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

    public Task<List<ControlAbono>> GetControlAbono()// se agrago cuando toque la interfaz preguntar el porq 
    {
        throw new NotImplementedException();
    }
}