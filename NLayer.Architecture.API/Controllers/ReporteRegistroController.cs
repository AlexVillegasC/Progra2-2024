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

public class ReporteRegistroController : ControllerBase
{
    private readonly  IReporteRegistroGanadoService _reporteGanadoService;


    public ReporteRegistroController(IReporteRegistroGanadoService reporteGanadoService)
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
    //Agregar
    [HttpPost("AddRegistroVacunas - Brandon ")]
    public async Task AddRegistroVacunas(Registro_de_Vacunas registro_De_Vacunas)
    {
        await _reporteGanadoService.AddRegistroVacunas(registro_De_Vacunas);
    }

    [HttpPut("UpdateRegistroVacunas - Brandon ")]
    public async Task<IActionResult> UpdateVacunas(Registro_de_Vacunas registro_De_Vacunas)
    {
        return await _reporteGanadoService.UpdateVacunas((IEnumerable<Registro_de_Vacunas>)registro_De_Vacunas) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteRegistroVacunas - Brandon")]
    public async Task<IActionResult> DeleteVacunas()
    {
        return await _reporteGanadoService.DeleteVacunas() ? Ok() : NotFound();
    }
}


