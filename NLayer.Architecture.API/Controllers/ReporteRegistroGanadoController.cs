using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.Services;
using NLayer.Architecture.Bussines.Models.RegistroGanado;
using NLayer.Architecture.Bussines.RegistroGanado;


namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]

public class ReporteRegistroGanadoController : ControllerBase
{
    private readonly  IReporteRegistroGanadoService _reporteGanadoService;


    public ReporteRegistroGanadoController(IReporteRegistroGanadoService reporteGanadoService)
    {
        _reporteGanadoService = reporteGanadoService;
    }

    [HttpGet]

    public async Task<LoteDeGanado> Get()
    {
        return await _reporteGanadoService.GetRegistroGanado();
    }
}// ....


