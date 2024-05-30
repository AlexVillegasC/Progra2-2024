using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.PronosticoLluvias;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

 [ApiController]
 [Route("[controller]")]
public class PronosticoLluviasController : ControllerBase
{ 
        private readonly IPronosticoLluviasServices _pronosticoLluviasService;

        public PronosticoLluviasController(IPronosticoLluviasServices pronosticoLluviasService)
        {
            _pronosticoLluviasService = pronosticoLluviasService;
        }

        [HttpGet]
        public async Task<PronosticoLluvias> Get()
        {
            return await _pronosticoLluviasService.GetPronosticos();
        }
    }

