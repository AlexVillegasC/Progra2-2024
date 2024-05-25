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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
=======
>>>>>>> 460e175 (Clase 13)
=======
>>>>>>> a88d30b (Advilleg - Post Temperatures)
=======
>>>>>>> 739f4a7 (Clase 13)
=======
>>>>>>> f932598 (Squashed commit of the following:)
    [HttpPost("AddTemperature", Name = "AddTemperature")]
    public async Task AddTemperature(Temperature temp)
=======
    [HttpPost]
    public async Task addTemperature(Temperature temp)
>>>>>>> d6270bd (Advilleg - Post Temperatures)
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 460e175 (Clase 13)
=======
    [HttpPost("AddTemperature", Name = "AddTemperature")]
    public async Task AddTemperature(Temperature temp)
>>>>>>> 6b13ada (Clase 13)
<<<<<<< HEAD
<<<<<<< HEAD
=======
    [HttpPost("AddTemperature", Name = "AddTemperature")]
    public async Task AddTemperature(Temperature temp)
>>>>>>> origin/development
=======
    [HttpPost]
    public async Task addTemperature(Temperature temp)
>>>>>>> 081ea19 (Advilleg - Post Temperatures)
=======
    [HttpPost("AddTemperature", Name = "AddTemperature")]
    public async Task AddTemperature(Temperature temp)
>>>>>>> 4f0ec2d (Clase 13)
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
=======
>>>>>>> 460e175 (Clase 13)
=======
=======
    [HttpPost]
    public async Task addTemperature(Temperature temp)
>>>>>>> d6270bd (Advilleg - Post Temperatures)
<<<<<<< HEAD
>>>>>>> a88d30b (Advilleg - Post Temperatures)
=======
=======
    [HttpPost("AddTemperature", Name = "AddTemperature")]
    public async Task AddTemperature(Temperature temp)
>>>>>>> 6b13ada (Clase 13)
<<<<<<< HEAD
>>>>>>> 739f4a7 (Clase 13)
=======
=======
    [HttpPost("AddTemperature", Name = "AddTemperature")]
    public async Task AddTemperature(Temperature temp)
>>>>>>> origin/development
>>>>>>> f932598 (Squashed commit of the following:)
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> a88d30b (Advilleg - Post Temperatures)
=======
=======
>>>>>>> 6b13ada (Clase 13)
>>>>>>> 739f4a7 (Clase 13)
=======
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> 6b13ada (Clase 13)
=======
>>>>>>> origin/development
=======
>>>>>>> 4f0ec2d (Clase 13)
=======
>>>>>>> 07c077a (Advilleg - Post Temperatures)
=======
=======
>>>>>>> 6b13ada (Clase 13)
<<<<<<< HEAD
>>>>>>> 460e175 (Clase 13)
=======
=======
>>>>>>> origin/development
>>>>>>> f932598 (Squashed commit of the following:)

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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 460e175 (Clase 13)
=======
>>>>>>> 739f4a7 (Clase 13)
=======
>>>>>>> f932598 (Squashed commit of the following:)
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
=======
>>>>>>> 6b13ada (Clase 13)
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> origin/development
=======
>>>>>>> 081ea19 (Advilleg - Post Temperatures)
=======
>>>>>>> 4f0ec2d (Clase 13)
=======
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
<<<<<<< HEAD
>>>>>>> 07c077a (Advilleg - Post Temperatures)
=======
>>>>>>> 460e175 (Clase 13)
=======
=======
>>>>>>> d6270bd (Advilleg - Post Temperatures)
>>>>>>> a88d30b (Advilleg - Post Temperatures)
=======
=======
>>>>>>> 6b13ada (Clase 13)
<<<<<<< HEAD
>>>>>>> 739f4a7 (Clase 13)
=======
=======
>>>>>>> origin/development
>>>>>>> f932598 (Squashed commit of the following:)
}
