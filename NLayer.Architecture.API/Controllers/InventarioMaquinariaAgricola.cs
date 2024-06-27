using Microsoft.AspNetCore.Mvc;

using NLayer.Architecture.Bussines.ReporteInventario;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]
public class InventarioMaquinariaAgricola : ControllerBase
{
    private readonly IReporteInventarioService _reporteInventarioService;

    public InventarioMaquinariaAgricola(IReporteInventarioService reporteInventarioService)
    {
        _reporteInventarioService = reporteInventarioService;
    }

    [HttpGet]
    public async Task<ReporteInventario> Get()
    {
        return await _reporteInventarioService.GetInventario();
    }

    [HttpPost("AddMaquinaria", Name = "AddMaquinaria")]
    public async Task AddMaquinaria(Maquinaria maqui)
    {
        await _reporteInventarioService.AddMaquinarias(maqui);
    }

    [HttpPut("UpdateMaquinaria", Name = "UpdateMaquinaria")]
    public async Task<IActionResult> UpdateMaquinaria(IEnumerable<Maquinaria> updatedMaquinaria)
    {
        return await _reporteInventarioService.UpdateMaquinaria(updatedMaquinaria) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteMaquinaria", Name = "DeleteMaquinaria")]
    public async Task<IActionResult> DeleteMaquinaria()
    {
        return await _reporteInventarioService.DeleteMaquinaria() ? Ok() : NotFound();
    }


    

   



    [HttpPost("AddMantenimiento", Name = "AddMantenimiento")]

    public async Task AddMantenimiento(Mantenimiento mantenimiento)
    {

      await _reporteInventarioService.AddMantenimiento(mantenimiento);

    }


    [HttpPut("UpdateMantenimiento", Name = "UpdateMantenimiento")]

    public async Task<IActionResult> UpdateMantenimiento(IEnumerable<Mantenimiento> updateMantenimiento)
    { 

    return await _reporteInventarioService.UpdateMantenimiento(updateMantenimiento) ? Ok() : NotFound();
    
    }


    [HttpDelete("DeleteMantenimiento", Name = "DeleteMantenimiento")]

    public async Task<IActionResult> DeleteMantenimiento()
    { 
    
    return await _reporteInventarioService.DeleteMantenimiento() ? Ok() : NotFound();

    }


    [HttpPost("AddHerramientas", Name = "AddHerramientas")]

    public async Task AddHerramientas(Herramientas herramientas)
    {
        await _reporteInventarioService.AddHerramientas(herramientas);
    }


    [HttpPut("UpDateHerramientas",Name ="UpdateHerramientas")]
    
    public async Task<IActionResult> UpdateHerramientas(IEnumerable<Herramientas> updateHerramientas)
    {
        return await _reporteInventarioService.UpdateHerramientas(updateHerramientas) ? Ok() : NotFound();
    }


    [HttpDelete("DeleteHerramientas", Name= "DeleteHerramientas")]
    public async Task<IActionResult> DeleteHerramientas()
    {
       return await _reporteInventarioService.DeleteHerramientas()? Ok() : NotFound();
    }


}

/*
Ok() : Devuelve un resultado de éxito con un código de estado HTTP 200 si la operación de actualización fue exitosa.
NotFound(): Devuelve un resultado de "no encontrado" con un código de estado HTTP 404 si la operación de actualización 
 no pudo llevarse a cabo(por ejemplo, si no se encontraron las temperaturas para actualizar).
*/