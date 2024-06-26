using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.Models.TheSillies;
using NLayer.Architecture.Bussines.Services;
using NLayer.Architecture.Bussines.TheSillies;

namespace NLayer.Architecture.API.Controllers;
[ApiController]
[Route("[Controller]")]
public class ReporteFinanzasController : Controller
{
    private readonly IReporteFinanzasServices _costosFinanzasServices;

    public ReporteFinanzasController (IReporteFinanzasServices costosHigieneServices)
    {
        _costosFinanzasServices = costosHigieneServices;
    }

    [HttpGet]
    public async Task<CostosGenerales> get() { return await _costosFinanzasServices.GetCostosGenerales(); }

    [HttpPost("AddCostosHigiene", Name = "AddCostosDeHigiene")]
    public async Task AddCostosHigiene (CostosHigiene costosHigiene)
    {
        await _costosFinanzasServices.AddCostosHigiene(costosHigiene);
    }

    [HttpPut("UpdateCostosHigiene", Name = "UpdateCostosHigiene")]
    public async Task<IActionResult> UpdateCostosHigiene(IEnumerable<CostosHigiene> updateCostosHigiene)
    {
        return await _costosFinanzasServices.UpdateCostosHigiene(updateCostosHigiene) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteCostosHigiene", Name ="DeleteCostosHigiene")]
    public async Task<IActionResult> DeleteCostosHigiene()
    {
        return await _costosFinanzasServices.DeleteCostosHigiene() ? Ok() : NotFound();
    }

    [HttpPost("AddCostosDeAlimentos", Name = "AddCostosDeAlimentos")]
    public async Task AddCostosAlimentos(CostosAlimenticios costosAlimenticios)
    {
        await _costosFinanzasServices.AddCostosAlimentos(costosAlimenticios);
    }

    [HttpPut("UpdateCostoDeAlimentos", Name = "UpdateCostoDeAlimentos")]
    public async Task<IActionResult> UpdateCostoAlimento(IEnumerable<CostosAlimenticios> updateCostoAlimento)
    {
        return await _costosFinanzasServices.UpdateCostoAlimento(updateCostoAlimento) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteCostosAlimenticios", Name = "DeleteCostosAlimenticios")]
    public async Task<IActionResult> DeleteCostosAlimenticios()
    {
        return await _costosFinanzasServices.DeleteCostosAlimenticios() ? Ok() : NotFound();
    }

    [HttpPost("AddCostosMedicina", Name = "AddCostosDeMedicina")]
    public async Task AddCostosMedicina(CostosMedicina costosMedicina)
    {
        await _costosFinanzasServices.AddCostosMedicina(costosMedicina);
    }

    [HttpPut("UpdateCostosMedicina", Name = "UpdateCostosMedicina")]
    public async Task<IActionResult> UpdateCostosMedicina(IEnumerable<CostosMedicina> updateCostosMedicina)
    {
        return await _costosFinanzasServices.UpdateCostosMedicina(updateCostosMedicina) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteCostosMedicina", Name = "DeleteCostosMedicina")]
    public async Task<IActionResult> DeleteCostosMedicina()
    {
        return await _costosFinanzasServices.DeleteCostosMedicina() ? Ok() : NotFound();
    }
}