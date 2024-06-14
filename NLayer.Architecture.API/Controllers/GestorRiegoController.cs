using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.GestorRiego;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GestorRiegoController : ControllerBase
    {
        private readonly IGestorRiegoService _gestorRiegoService;

        public GestorRiegoController(IGestorRiegoService gestorRiegoService)
        {
                _gestorRiegoService  = gestorRiegoService;
        }

        [HttpGet]
        public async Task<GestorRiego> Get()
        {
            return await _gestorRiegoService.GetEstadoRiego();
        }


        [HttpPost("AddTemperatura", Name = "AddTemperatura")]
        public async Task AddTemperatura(Temperatura temperatura)
        {
            // 1. Agrega Temperatura
            await _gestorRiegoService.AddTemperatura(temperatura);
            // 2. Responde

        }

        [HttpPost("AddCultivo", Name = "AddCultivo")]
        public async Task AddCultivo(Cultivo cultivo)
        {
            // 1. Agrega Temperatura
            await _gestorRiegoService.AddCultivo(cultivo);
            // 2. Responde

        }

        [HttpPost("AddHumedadSuelo", Name = "HumedadSuelo")]
        public async Task AddHumedadSuelo(HumedadSuelo humedadSuelo)
        {
            // 1. Agrega Temperatura
            await _gestorRiegoService.AddHumedadSuelo(humedadSuelo);
            // 2. Responde

        }

        /* [HttpPost]

         public async Task<IActionResult> AddGestorRiego(GestorRiego gestorRiego)
         {

             if (gestorRiego._Temperatura != null)
             {
                 await _gestorRiegoService.AddTemperatura(gestorRiego._Temperatura);
             }

             if (gestorRiego._Cultivo != null)
             {
                 await _gestorRiegoService.AddCultivo(gestorRiego._Cultivo);
             }

             if (gestorRiego._HumedadSuelo != null)
             {
                 await _gestorRiegoService.AddHumedadSuelo(gestorRiego._HumedadSuelo);
             }

             return CreatedAtAction(nameof(AddGestorRiego), gestorRiego);
         }
        */

    }
}
