using NLayer.Architecture.Bussines.ReporteInventarioRecursos;

public interface IReporteInventarioRecursosServices
{
    Task<ReporteInventarioRecursosBase> Inventario { get; }

    Task<ReporteInventarioRecursosBase> GetInventario();

    Task AddFertilizantes(Fertilizantes fertilizantes);

    Task<bool> UpdateFertilizantes(IEnumerable<Fertilizantes> fertilizantes);

    Task<bool> DeleteFertilizantes();


    Task AddPesticidas(Pesticidas pesticidas);

    Task<bool> UpdatePesticidas(IEnumerable<Pesticidas> pesticidas);

    Task<bool> DeletePesticidas();

}
