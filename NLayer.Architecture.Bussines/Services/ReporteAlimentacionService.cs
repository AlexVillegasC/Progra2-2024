using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Bussines.ReporteAlimentacion;


namespace NLayer.Architecture.Bussines.Services;

public class ReporteAlimentacionService : IReporteAlimentacionService
{
    private readonly IReporteAlimentacionRepository _reporteAliRepo;

    public ReporteAlimentacionService(IReporteAlimentacionRepository reporteAlimentacionRepository)
    {
        _reporteAliRepo = reporteAlimentacionRepository;
    }

    public async Task<Produccion> GetProduccion()

    {
        Produccion miReporte = new()
        {
            Trabajadores = await _reporteAliRepo.GetTrabajadores(),
            ListaAnimales = await _reporteAliRepo.GetAnimales(),
            ListaAlimentos = await _reporteAliRepo.GetAlimentos()
        };
        miReporte.CalcularCostos();

        return miReporte;
    }
     public async Task AddAlimentos(Alimentos alimentos)
    {
        await _reporteAliRepo.AddAlimentos(alimentos);
    }
    public async Task<bool> UpdateAlimento(IEnumerable<Alimentos> alimentos)
    {
        return await _reporteAliRepo.UpdateAlimento(alimentos);
    }

}
