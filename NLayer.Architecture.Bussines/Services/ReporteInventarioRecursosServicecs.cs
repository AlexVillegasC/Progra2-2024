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






}

