using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Bussines.ReporteAlimentacion;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ReporteAlimentacionNutricionController : ControllerBase
{
    private readonly IReporteAlimentacionService _reporteAlimentacionService;

    public ReporteAlimentacionNutricionController(IReporteAlimentacionService reporteAlimentacionService)
    {
        _reporteAlimentacionService = reporteAlimentacionService;
    }

    [HttpGet]
    public async Task<Produccion> Get()
    {
        return await _reporteAlimentacionService.GetProduccion();
    }

    [HttpPost("AddAlimentos", Name = "AddAlimentos")]
    public async Task AddAlimento(Alimentos ali)
    {
        await _reporteAlimentacionService.AddAlimentos(ali);
    }
}
