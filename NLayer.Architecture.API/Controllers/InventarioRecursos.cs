using Microsoft.AspNetCore.Mvc;

using NLayer.Architecture.Bussines.ReporteInventarioRecursos;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]
public class InventarioRecursos : ControllerBase
{
    private readonly IReporteInventarioRecursosServices _reporteInventarioRecursosService;

    public InventarioRecursos(IReporteInventarioRecursosServices reporteInventarioRecursosService)
    {
        _reporteInventarioRecursosService = reporteInventarioRecursosService;
    }
    [HttpGet]
    public async Task<ReporteInventarioRecursos> Get()
    {
        return await _reporteInventarioRecursosService.GetInventario();
    }
}