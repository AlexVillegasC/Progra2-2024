using NLayer.Architecture.Bussines.ReporteInventarioRecursos;
using DataAccess.Layer.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;

public class ReporteInventarioRecursosService : IReporteInventarioRecursosServices
{
    
    private readonly IReporteInventarioRecursosRepository _inventarioRecursos;

    public ReporteInventarioRecursosService(IReporteInventarioRepository inventarioRecursos)
    {
        _inventarioRecursos = (IReporteInventarioRecursosRepository?)inventarioRecursos;
    }

  
    public async Task<ReporteInventarioRecursos.ReporteInventarioRecursos> GetInventario()
    {
    
        ReporteInventarioRecursos.ReporteInventarioRecursos miInventario = new ReporteInventarioRecursos.ReporteInventarioRecursos();

    
        miInventario.Pesticidas = await _inventarioRecursos.GetPesticidas();
        miInventario.Fertilizantes = await _inventarioRecursos.GetFertilizantes();
        return miInventario;


    }
    public async Task AddFertlizantes(Fertilizantes fertilizantes)
    {
        await _inventarioRepo.AddFertilizantes(fertilizantes);
    }

    public async Task<bool> UpdateFertilizantes(IEnumerable<Fertilizantes> fertilizantes)
    {
        return await _inventarioRepo.UpdateFertilizantes(fertilizantes);
    }

    public async Task<bool> DeleteFertilizantes()
    {
        return await _inventarioRepo.DeleteFertilizantes();
    }







    public async Task AddPesticidas(Pesticidas pesticidas)
    {

        await _inventarioRepo.AddPesticidas(pesticidas);

    }



    public async Task<bool> UpdatePesticidas(IEnumerable<Pesticidas> pesticidas)
    {

        return await _inventarioRepo.UpdatePesticidas(pesticidas);

    }



    public async Task<bool> DeletePesticidas()
    {

        return await _inventarioRepo.DeletePesticidas();
    }

}

}

