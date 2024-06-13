using Microsoft.AspNetCore.Mvc;

using NLayer.Architecture.Bussines.ReporteInventarioRecursos;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]
public class InventarioRecursos : ControllerBase
{
    private readonly IReporteInventarioRecursosServices _reporteInventarioRecursosServices;

    public InventarioRecursos(IReporteInventarioRecursosServices reporteInventarioRecursosService)
    {
        _reporteInventarioRecursosServices = reporteInventarioRecursosService;
    }
    [HttpGet]
    public async Task<ReporteInventarioRecursos> Get()
    {
        return await _reporteInventarioRecursosServices.GetInventario();
    }

    [HttpPost("AddFertilizantes", Name = "AddFertilizantes")]
    public async Task AddFertilizantes(Fertilizantes fertilizantes)
    {
        await _reporteInventarioRecursosServices.AddFertilizantes(fertilizantes);
    }

    [HttpPut("UpdateFertilizantes", Name = "UpdateFertilizantes")]
    public async Task<IActionResult> UpdateFertilizantes(IEnumerable<Fertilizantes> updatedFertilizantes)
    {
        return await _reporteInventarioRecursosServices.UpdateFertilizantes(updatedFertilizantes) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteFertilizantes", Name = "DeleteFertilizantes")]
    public async Task<IActionResult> DeleteFertilizantes()
    {
        return await _reporteInventarioRecursosServices.DeleteFertilizantes() ? Ok() : NotFound();
    }

    [HttpPost("AddPesticidas", Name = "AddPesticidas")]
    public async Task AddPesticidas(Pesticidas pesticidas)
    {
        await _reporteInventarioRecursosServices.AddPesticidas(pesticidas);
    }

    [HttpPut("UpdatePesticidas", Name = "UpdatePesticidas")]
    public async Task<IActionResult> UpdatePesticidas(IEnumerable<Pesticidas> updatedPesticidas)
    {
        return await _reporteInventarioRecursosServices.UpdatePesticidas(updatedPesticidas) ? Ok() : NotFound();
    }

    [HttpDelete("DeletePesticidas", Name = "DeletePesticidas")]
    public async Task<IActionResult> DeletePesticidas()
    {
        return await _reporteInventarioRecursosServices.DeletePesticidas() ? Ok() : NotFound();
    }

}