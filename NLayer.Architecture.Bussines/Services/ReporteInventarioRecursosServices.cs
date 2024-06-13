using NLayer.Architecture.Bussines.ReporteInventarioRecursos;
using DataAccess.Layer.FileRepositories;
using DataAccess.Layer.FileRepositories;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Runtime.InteropServices;


namespace NLayer.Architecture.Bussines.Services;

public class ReporteInventarioRecursosServices : IReporteInventarioRecursosServices
{
    
    private readonly IReporteInventarioRecursosRepository _inventarioRecursos;

    public ReporteInventarioRecursosServices(IReporteInventarioRepository inventarioRecursos)
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
        await _inventarioRecursos.AddFertilizantes(fertilizantes);
    }

    public async Task<bool> UpdateFertilizantes(IEnumerable<Fertilizantes> fertilizantes)
    {
        return await _inventarioRecursos.UpdateFertilizantes(fertilizantes);
    }

    public async Task<bool> DeleteFertilizantes()
    {
        return await _inventarioRecursos.DeleteFertilizantes();
    }







    public async Task AddPesticidas(Pesticidas pesticidas)
    {

        await _inventarioRecursos.AddPesticidas(pesticidas);

    }



    public async Task<bool> UpdatePesticidas(IEnumerable<Pesticidas> pesticidas)
    {

        return await _inventarioRecursos.UpdatePesticidas(pesticidas);

    }



    public async Task<bool> DeletePesticidas()
    {

        return await _inventarioRecursos.DeletePesticidas();
    }

}

}

