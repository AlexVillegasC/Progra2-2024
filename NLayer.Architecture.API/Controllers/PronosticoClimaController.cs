using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PronosticoClimaController : ControllerBase
{
    private readonly IReporteClimaService _reporteClimaService;

    public PronosticoClimaController(IReporteClimaService reporteClimaService)
    {
        _reporteClimaService = reporteClimaService;
    }

    [HttpGet]
    public async Task<ReporteClima> Get()
    {        
        return await _reporteClimaService.GetPronostico();
    }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    [HttpPost("AddTemperature", Name = "AddTemperature")]
    public async Task AddTemperature(Temperature temp)
=======
    [HttpPost]
    public async Task addTemperature(Temperature temp)
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
    [HttpPost("AddTemperature", Name = "AddTemperature")]
    public async Task AddTemperature(Temperature temp)
>>>>>>> 6b13ada (Clase 13)
=======
    [HttpPost]
    public async Task addTemperature(Temperature temp)
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
    [HttpPost("AddTemperature", Name = "AddTemperature")]
    public async Task AddTemperature(Temperature temp)
>>>>>>> 6b13ada (Clase 13)
=======
    [HttpPost("AddTemperature", Name = "AddTemperature")]
    public async Task AddTemperature(Temperature temp)
>>>>>>> origin/development
=======
    [HttpPost]
    public async Task addTemperature(Temperature temp)
>>>>>>> d6270bd (Advilleg - Post Temperatures)
    {
        // 1. Agrega Temperatura
        await _reporteClimaService.AddTemperature(temp);
        // 2. Responde

    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 6b13ada (Clase 13)
=======
>>>>>>> 6b13ada (Clase 13)
=======
>>>>>>> origin/development

    [HttpPut("UpdateTemperature", Name = "UpdateTemperature")]
    public async Task<IActionResult> UpdateTemperature(IEnumerable<Temperature> updatedTemperature)
    {
        return await _reporteClimaService.UpdateTemperature(updatedTemperature) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteTemperature", Name = "DeleteTemperature")]
    public async Task<IActionResult> DeleteTemperature()
    {
        return await _reporteClimaService.DeleteTemperature() ? Ok() : NotFound();    
    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
>>>>>>> 6b13ada (Clase 13)
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
>>>>>>> 6b13ada (Clase 13)
=======
>>>>>>> origin/development
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
}
