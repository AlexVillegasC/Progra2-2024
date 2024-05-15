
namespace NLayer.Architecture.Bussines.Services;

public interface IReporteInventarioService
{
    
    Task<ReporteInventario.ReporteInventario> GetInventario();

    Task<ReporteInventario.ReporteInventario> GetInventario1();
}
