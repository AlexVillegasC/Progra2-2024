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
    }
}
