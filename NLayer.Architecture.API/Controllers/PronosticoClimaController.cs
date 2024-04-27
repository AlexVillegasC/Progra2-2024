using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PronosticoClimaController : ControllerBase
{
    private readonly IReporteClimaService _reporteClimaService;

    public PronosticoClimaController(IReporteClimaService reporteClimaService)
    {
        _reporteClimaService = reporteClimaService;
    }

    [HttpGet]
    public async Task<ReporteClima> Get()
    {        
        return await _reporteClimaService.GetPronostico();
    }
}
