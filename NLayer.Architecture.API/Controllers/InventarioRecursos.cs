using Microsoft.AspNetCore.Mvc;

using NLayer.Architecture.Bussines.ReporteInventario;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]
public class InventarioRecursos : ControllerBase
{
    private readonly IReporteInventarioService _reporteInventarioService;

    public InventarioRecursos(IReporteInventarioService reporteInventarioService)
    {
        _reporteInventarioService = reporteInventarioService;
    }
    [HttpGet]
    public async Task<ReporteInventario> Get()
    {
        return await _reporteInventarioService.GetInventario();
    }
}