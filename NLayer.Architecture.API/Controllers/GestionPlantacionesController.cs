using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.GestionPlantaciones;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]

public class GestionPlantacionesController : ControllerBase
{
    private readonly IReportePlantaciones _reportePlantaciones;

    public GestionPlantacionesController(IReportePlantaciones reportePlantaciones)
    {
        _reportePlantaciones = reportePlantaciones;
    }





































    [HttpGet]
    public async Task<GestionPlantaciones> Get()
    {
        return await _reportePlantaciones.GetReporte();
    }

    [HttpPost("AddPlaga", Name = "AddPlaga")]
    public async Task AddPlaga(ControlPlagas plag)
    {
        await _reportePlantaciones.AddPlaga(plag);
    }

    [HttpPut("UpdatePlaga", Name = "UpdatePlaga")]
    public async Task<IActionResult> UpdatePlaga(IEnumerable<ControlPlagas> updatePlaga)
    {
        return await _reportePlantaciones.UpdatePlaga(updatePlaga) ? Ok() : NotFound();
    }

    [HttpDelete("DeletePlaga", Name = "DeletePlaga")]
    public async Task<IActionResult> DeletePlaga()
    {
        return await _reportePlantaciones.DeletePlaga() ? Ok() : NotFound();
    }

}