using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Business.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Business.ReporteAlimentacion;
using NLayer.Architecture.Business.ReporteClima;
using NLayer.Architecture.Business.Services;

namespace NLayer.Architecture.API.Controllers
{
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

        [HttpPut("UpdateAlimento", Name = "UpdateAlimento")]
        public async Task<IActionResult> UpdateTemperature(IEnumerable<Alimentos> updatedAlimento)
        {
            return await _reporteAlimentacionService.UpdateAlimento(updatedAlimento) ? Ok() : NotFound();
        }
   }
}