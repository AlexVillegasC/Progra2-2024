using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.Services;
using NLayer.Architecture.Bussines.Models.RegistroGanado;
using NLayer.Architecture.Bussines.RegistroGanado;
using NLayer.Architecture.Bussines;
namespace NLayer.Architecture.API.Controllers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class ReporteRegistroGanadoController : ControllerBase
{
    private readonly  IReporteRegistroGanadoService _reporteGanadoService;


    public ReporteRegistroGanadoController(IReporteRegistroGanadoService reporteGanadoService)
    {
        _reporteGanadoService = reporteGanadoService;
    }

    [HttpGet("Get-Frander")]

    public async Task<LoteDeGanado> Get()
    {
        return await _reporteGanadoService.GetRegistroGanado();
    }

     [HttpPost("AddGanado - Frander ")]
        public async Task<IActionResult> AddGanado([FromBody] Ganado ganado)
        {
            if (ganado == null)
            {
                return BadRequest();
            }

            await _reporteGanadoService.AddGanado(ganado);
            return Ok();
        }
        [HttpPut("UpdateGanado - Frander")]
        public async Task<IActionResult> UpdateGanado([FromBody] IEnumerable<Ganado> updatedGanado)
        {
            if (updatedGanado == null)
            {
                return BadRequest();
            }

            bool result = await _reporteGanadoService.UpdateGanado(updatedGanado);
            return result ? Ok() : NotFound();
        }

        [HttpDelete("DeleteGanado - Frander")]
        public async Task<IActionResult> DeleteTemperature()
        {
        return await _reporteGanadoService.DeleteGanado() ? Ok() : NotFound();    
        }

}

