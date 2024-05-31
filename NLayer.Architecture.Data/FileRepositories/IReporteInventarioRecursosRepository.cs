using NLayer.Architecture.Bussines.ReporteInventarioRecursos;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteInventarioRecursosRepository
{
    Task<Pesticidas> GetPesticidas();

    Task<Fertilizantes> GetFertilizantes();

}

