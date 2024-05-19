using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.GestionCultivo;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CultivosController : ControllerBase
{
    private readonly ICultivoService _cultivoService;

    public CultivosController(ICultivoService cultivoService)
    {
        _cultivoService = cultivoService;
    }


    [HttpGet]
    public async Task<GestionCultivo> Get()
    {
        return await _cultivoService.GetCultivo();
    }
}
