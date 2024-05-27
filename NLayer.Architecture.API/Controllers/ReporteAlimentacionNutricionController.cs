using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;
using NLayer.Architecture.Bussines.ReporteAlimentacion;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Bussines.Services;

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

        [HttpPost("AddTrabajadores", Name = "AddTrabajadores")]
        public async Task AddTrabajadores(Trabajadores tra)
        {
            await _reporteAlimentacionService.AddTrabajadores(tra);
        }
        [HttpPost("AddAnimals", Name = "AddAnimals")]
        public async Task AddAnimals(Animales animals)
        {
            await _reporteAlimentacionService.AddAnimals(animals);
        }

        [HttpPut("UpdateAlimento", Name = "UpdateAlimento")]
        public async Task<IActionResult> UpdateTemperature(IEnumerable<Alimentos> updatedAlimento)
        {
            return await _reporteAlimentacionService.UpdateAlimento(updatedAlimento) ? Ok() : NotFound();
        }
        [HttpPut("UpdateAnimales", Name = "UpdateAnimales")]
        public async Task<IActionResult> UpdateTemperature(IEnumerable<Animales> updatedAnimales)
        {
            return await _reporteAlimentacionService.UpdateAnimales(updatedAnimales) ? Ok() : NotFound();
        }
        [HttpDelete("DeleteAlimentos", Name = "DeleteAlimentos")]
         public async Task<IActionResult> DeleteAlimentos()
         {
             return await _reporteAlimentacionService.DeleteAlimentos() ? Ok() : NotFound();
         }
        [HttpDelete("DeleteAnimals", Name = "DeleteAnimals")]
        public async Task<IActionResult> DeleteAnimals()
        {
            return await _reporteAlimentacionService.DeleteAnimals() ? Ok() : NotFound();
        }
    }
}

