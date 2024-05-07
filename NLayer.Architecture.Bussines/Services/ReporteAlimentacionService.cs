using DataAccess.Layer.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;

public class ReporteAlimentacionService
{
    private readonly IReporteAlimentacionRepository _reporteAliRepo;

    public ReporteAlimentacionService(IReporteAlimentacionRepository reporteAlimentacionRepository)
    {
        _reporteAliRepo = reporteAlimentacionRepository;
    }
    public async Task<ReporteAlimentacion.Produccion> GetProduccion()
    {
        ReporteAlimentacion.Produccion miReporte = new ReporteAlimentacion.Produccion();
        miReporte.Trabajadores = await _reporteAliRepo.GetTrabajadores();

        return miReporte;
    }

}
