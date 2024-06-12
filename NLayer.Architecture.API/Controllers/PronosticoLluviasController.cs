using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.Models.MonitoreoClimatico;
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
        try
        {
            return await _pronosticoLluviasService.GetPronosticos();
        }
        catch (Exception ex)
        {
            // Captura la excepción y registra el error.
            // Aquí puedes usar un sistema de logging para registrar el error, por ejemplo:
            // _logger.LogError(ex, "An error occurred while getting the forecast.");

            // Lanzar una excepción más específica o devolver un valor por defecto
            // dependiendo de cómo prefieras manejar el error en tu aplicación.

            // Ejemplo de lanzar una nueva excepción:
            throw new ApplicationException("Se produjo un error al obtener el pronóstico de lluvias.", ex);

            // Ejemplo de devolver un valor por defecto:
            // return new PronosticoLluvias(); // Suponiendo que tenga un constructor por defecto.
        }
    }



















    [HttpPost ("AddLluviaLargoPlazo", Name = "AddLluviaLargoPlazo")]
    public async Task AddLluviaLargoPlazo(LluviaLargoPlazo lluviaLargoPlazo)
    {
        await _pronosticoLluviasService.AddLluviaLargoPlazo(lluviaLargoPlazo);
    }



    [HttpPut("UpdateLluviaLargoPlazo", Name = "UpdateLluviaLargoPlazo")]
    public async Task<IActionResult> UpdateLluviaLargoPlazo(IEnumerable<LluviaLargoPlazo> updateLluviaLargoPlazo)
    {
        return await _pronosticoLluviasService.UpdateLluviaLargoPlazo(updateLluviaLargoPlazo)? Ok () : NotFound ();
    }



    [HttpDelete("DeleteLluviaLargoPlazo", Name = "DeleteLluviaLargoPlazo")]
    public async Task<IActionResult> DeleteLluviaLargoPlazo ()
    {
        return await _pronosticoLluviasService.DeleteLluviaLargoPlazo() ? Ok() : NotFound();
    }
}



