
using NLayer.Architecture.Bussines.ReporteInventario;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteInventarioRepository
{
    Task<Maquinaria> GetMaquinaria();

    Task<Herramientas> GetHerramientas();
}
