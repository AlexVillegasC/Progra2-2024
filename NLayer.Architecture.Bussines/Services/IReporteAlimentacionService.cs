
namespace NLayer.Architecture.Bussines.Services;

public interface IReporteAlimentacionService
{
    Task<ReporteAlimentacion.Produccion> GetProduccion();
}
