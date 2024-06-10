using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.Services;
using NLayer.Architecture.Bussines.Models.RegistroGanado;
using NLayer.Architecture.Bussines.RegistroGanado;
using NLayer.Architecture.Bussines;
namespace NLayer.Architecture.API.Controllers;

using System.Security.Cryptography.X509Certificates;
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

    [HttpGet("Get")]

    public async Task<LoteDeGanado> Get()
    {
        return await _reporteGanadoService.GetRegistroGanado();
    }

     [HttpPost("AddGanado - Frander ")]
    public async Task AddGanado (Ganado ganado)
    {
        await _reporteGanadoService.AddGanado(ganado);
    }
     
     [HttpPut("UpdateGanado - Frander ")]
    public async Task<IActionResult> UpdateGanado (Ganado ganado)
    {
        return await _reporteGanadoService.UpdateGanado((IEnumerable<Ganado>)ganado) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteGanado - Frander")]
    public async Task<IActionResult> DeleteGanado ()
    {
        return await _reporteGanadoService.DeleteGanado() ?  Ok() : NotFound();
    }

}


