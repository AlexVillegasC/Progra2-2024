using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Bussines.ReporteAlimentacion;
using NLayer.Architecture.Bussines.ReporteClima;
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
    [HttpPut("UpdateAlimento", Name = "UpdateAlimento")]
    public async Task<IActionResult> UpdateTemperature(IEnumerable<Alimentos> updatedAlimento)
    {
        return await _reporteAlimentacionService.UpdateAlimento(updatedAlimento) ? Ok() : NotFound();
    }
}
