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
            throw new ApplicationException("Se produjo un error al obtener el pronóstico de lluvias.", ex);
        }
    }

    [HttpPost ("AddLluviaMedianoPlazo", Name = "AddLluviaMedianoPlazo")]
    public async Task AddLluviaMedianoPlazo(LluviaMedianoPlazo lluviaMedianoPlazo)
    {
        await _pronosticoLluviasService.AddLluviaMedianoPlazo(lluviaMedianoPlazo);
    }

    [HttpPut("UpdateLluviaMedianoPlazo", Name = "UpdateLluviaMedianoPlazo")]
    public async Task<IActionResult> UpdateLluviaMedianoPlazo(IEnumerable<LluviaMedianoPlazo> updateLluviaMedianoPlazo)
    {
        return await _pronosticoLluviasService.UpdateLluviaMedianoPlazo(updateLluviaMedianoPlazo)? Ok() : NotFound();
    }

    [HttpDelete("DeleteLluviaMedianoPlazo", Name = "DeleteLluviaMedianoPlazo")]
    public async Task<IActionResult> DeleteLluviaMedianoPlazo ()
    {
        return await _pronosticoLluviasService.DeleteLluviaMedianoPlazo() ? Ok() : NotFound();    }



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



