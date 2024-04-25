using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PronosticoClimaController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<PronosticoClimaController> _logger;
    private readonly IReporteClimaService _reporteClimaService;

    public PronosticoClimaController(ILogger<PronosticoClimaController> logger, IReporteClimaService reporteClimaService)
    {
        _logger = logger;
        _reporteClimaService = reporteClimaService;
    }
    
    public async Task<ReporteClima> Get()
    {
        return await _reporteClimaService.GetPronostico(1);
    }
}
