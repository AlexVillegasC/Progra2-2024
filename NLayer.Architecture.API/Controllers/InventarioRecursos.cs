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

    [HttpPost("AddFertilizantes", Name = "AddFertilizantes")]
    public async Task AddFertilizantes(Fertilizantes fertilizantes)
    {
        await _reporteInventarioRecursosService.AddFertilizantes(fertilizantes);
    }

    [HttpPut("UpdateFertilizantes", Name = "UpdateFertilizantes")]
    public async Task<IActionResult> UpdateFertilizantes(IEnumerable<Fertilizantes> updatedFertilizantes)
    {
        return await _reporteInventarioRecursosService.UpdateFertilizantes(updatedFertilizantes) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteFertilizantes", Name = "DeleteFertilizantes")]
    public async Task<IActionResult> DeleteFertilizantes()
    {
        return await _reporteInventarioRecursosService.DeleteFertilizantes() ? Ok() : NotFound();
    }

    [HttpPost("AddPesticidas", Name = "AddPesticidas")]
    public async Task AddPesticidas(Pesticidas pesticidas)
    {
        await _reporteInventarioRecursosService.AddPesticidas(pesticidas);
    }

    [HttpPut("UpdatePesticidas", Name = "UpdatePesticidas")]
    public async Task<IActionResult> UpdatePesticidas(IEnumerable<Pesticidas> updatedPesticidas)
    {
        return await _reporteInventarioRecursosService.UpdatePesticidas(updatedPesticidass) ? Ok() : NotFound();
    }

    [HttpDelete("DeletePesticidas", Name = "DeletePesticidas")]
    public async Task<IActionResult> DeletePesticidas()
    {
        return await _reporteInventarioRecursosService.DeletePesticidas() ? Ok() : NotFound();
    }

}