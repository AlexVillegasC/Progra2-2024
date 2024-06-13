using NLayer.Architecture.Bussines.ReporteInventario;
using NLayer.Architecture.Bussines.ReporteInventarioRecursos;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteInventarioRecursosRepository
{
    Task<List<Fertilizantes>> GetFertilizantes();
    Task AddFertilizantes(Fertilizantes fertilizantes);

    Task<bool> UpdateFertilizantes(IEnumerable<Fertilizantes> fertilizantes);

    Task<bool> DeleteFertilizantes();


    Task<List<Pesticidas>> GetPesticidas();

    Task AddPesticidas(Pesticidas pesticidas);

    Task<bool> UpdatePesticidas(IEnumerable<Pesticidas> pesticidas);

    Task<bool> DeletePesticidas();
}