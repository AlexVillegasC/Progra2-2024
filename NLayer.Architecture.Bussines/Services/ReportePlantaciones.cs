using DataAccess.Layer.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;

public class ReportePlantaciones : IReportePlantaciones
{
    private readonly IReportePlantaciones _plantaciones;

    public ReportePlantaciones(IReportePlantaciones plantaciones)
    {
        _plantaciones = plantaciones;
    }

    public async Task<GestionPlantaciones.GestionPlantaciones> GetReporte()
    {
        GestionPlantaciones.GestionPlantaciones reporte = new GestionPlantaciones.GestionPlantaciones();
        // reporte.Plagas = await _plantaciones

        return reporte;
    }
}
