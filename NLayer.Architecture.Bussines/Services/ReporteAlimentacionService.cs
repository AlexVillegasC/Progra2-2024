using DataAccess.Layer.FileRepositories;
using System.Collections.Generic;
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
        miReporte.ListaAnimales = await _reporteAliRepo.GetAnimales();

        miReporte

        return miReporte;
    }

}
