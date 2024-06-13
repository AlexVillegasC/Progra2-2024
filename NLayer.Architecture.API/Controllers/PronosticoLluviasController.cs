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
    

    [HttpPost("AddLluviaCortoPlazo", Name = "AddLluviaCortoPlazo")]
    public async Task AddLluviaCortoPlazo(LluviaCortoPlazo lluviaMedianoPlazo)
    {
        await _pronosticoLluviasService.AddLluviaCortoPlazo(lluviaMedianoPlazo);
    }

    [HttpPut("UpdateLluviaCortoPlazo", Name = "UpdateLluviaCortoPlazo")]
    public async Task<IActionResult> UpdateLluviaCortoPlazo(IEnumerable<LluviaCortoPlazo> updateLluviaCortoPlazo)
    {
        return await _pronosticoLluviasService.UpdateLluviaCortoPlazo(updateLluviaCortoPlazo) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteLluviaCortoPlazo", Name = "DeleteLluviaCortoPlazo")]
    public async Task<IActionResult> DeleteLluviaCortoPlazo()
    {
        return await _pronosticoLluviasService.DeleteLluviaCortoPlazo() ? Ok() : NotFound();
    }
}




