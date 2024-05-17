using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.GestionRiego;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PronosticoClimaController : ControllerBase
{
    private readonly IGestionRiegoService _reporteClimaService;

    public PronosticoClimaController(IGestionRiegoService reporteClimaService)
    {
        _reporteClimaService = reporteClimaService;
    }

    [HttpGet]
    public async Task<GestionRiego> Get()
    {        
        return await _reporteClimaService.GetPronostico();
    }
}
