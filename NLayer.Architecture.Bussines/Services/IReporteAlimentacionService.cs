
using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Bussines.ReporteAlimentacion;


namespace NLayer.Architecture.Bussines.Services;

public interface IReporteAlimentacionService
{

    Task<ReporteAlimentacion.Produccion> GetProduccion();
    Task AddAlimentos(Alimentos alimentos);
    Task<Produccion> GetProduccion();
    Task<bool>UpdateAlimento(IEnumerable<Alimentos> alimentos);

}
