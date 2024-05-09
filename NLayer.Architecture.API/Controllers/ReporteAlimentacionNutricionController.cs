using Microsoft.AspNetCore.Mvc;
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
        // Aquí es donde se obtiene la producción del servicio
        var produccion = await _reporteAlimentacionService.GetProduccion();

        // Aquí es donde se calculan los costos (parte agregada)
        produccion.CalcularCostos();

        return produccion;
    }
}
