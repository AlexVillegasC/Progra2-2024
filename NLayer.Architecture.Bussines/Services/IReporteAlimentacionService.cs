
namespace NLayer.Architecture.Bussines.Services;

internal interface IReporteAlimentacionService
{
    Task<ReporteAlimentacion.Produccion> GetProduccion();
}
