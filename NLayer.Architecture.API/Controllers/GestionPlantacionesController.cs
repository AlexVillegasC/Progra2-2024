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

   

    //-------------ABONO----------------------------------//
    [HttpPost("AddTControlAbono", Name = "AddAbono")]
    public async Task AddControlaAbono(ControlAbono abo)
    {
        // 1. Agrega Temperatura
        await _reportePlantaciones.AddControlAbono(abo);
        // 2. Responde

    }
    [HttpPut("UpdateControlAbono", Name = "UpdateControlAbono")]
    public async Task<IActionResult> UpdateControlAbono(IEnumerable<ControlAbono> updatedControlAbono)
    {
        return await _reportePlantaciones.UpdateControlAbono(updatedControlAbono) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteControlAbono", Name = "DeleteAbono")]
    public async Task<IActionResult> DeleteControlAbono()
    {
        return await _reportePlantaciones.DeleteControlAbono() ? Ok() : NotFound();
    }
    //-------------ABONO----------------------------------//



    //-------------PLAGAS----------------------------------//

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

    //-------------PLAGAS----------------------------------//


    //-------------ARBOL----------------------------------//

    [HttpPost("ArbolFrutal", Name = "AddArbolFrutal")]
    public async Task addArbolFrutal(ArbolFrutal arb)
    {
        await _reportePlantaciones.AddArbolFrutal(arb);
    }

    [HttpPut("UpdateArbolFrutal", Name = "UpdateArbolFrutal")]
    public async Task<IActionResult> UpdateArbolFrutal(IEnumerable<ArbolFrutal> updateArbolFrutal)
    {
        return await _reportePlantaciones.UpdateArbolFrutal(updateArbolFrutal) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteArbolFrutal", Name = "DeleteArbolFrutal")]
    public async Task<IActionResult> DeleteArbolFrutal()
    {
        return await _reportePlantaciones.DeleteArbolFrutal() ? Ok() : NotFound();
    }

    //-------------ARBOL----------------------------------//


}