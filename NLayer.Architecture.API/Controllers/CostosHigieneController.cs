using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.Models.TheSillies;
using NLayer.Architecture.Bussines.Services;
using NLayer.Architecture.Bussines.TheSillies;

namespace NLayer.Architecture.API.Controllers;
[ApiController]
[Route("[Controller]")]
public class CostosHigieneController : Controller
{
    private readonly ICostosHigieneServices _costosHigieneServices;

    public CostosHigieneController (ICostosHigieneServices costosHigieneServices)
    {
        _costosHigieneServices = costosHigieneServices;
    }

    [HttpGet]
    public async Task<CostosGenerales> get() { return await _costosHigieneServices.GetCostosGenerales(); }

    [HttpPost("AddCostosHigiene", Name = "AddCostosDeHigiene")]
    public async Task AddCostosHigiene (CostosHigiene costosHigiene)
    {
        await _costosHigieneServices.AddCostosHigiene(costosHigiene);
    }

    [HttpPost("AddCostosDeAlimentos", Name = "AddCostosDeAlimentos")]
    public async Task AddCostosAlimentos(CostosAlimenticios costosAlimenticios)
    {
        await _costosHigieneServices.AddCostosAlimentos(costosAlimenticios);
    }

    [HttpPut("UpdateCostoDeAlimentos", Name = "UpdateCostoDeAlimentos")]
    public async Task<IActionResult> UpdateCostoAlimento(IEnumerable<CostosAlimenticios> updateCostoAlimento)
    {
        return await _costosHigieneServices.UpdateCostoAlimento(updateCostoAlimento) ? Ok() : NotFound();
    }

    [HttpDelete("DeleteCostosAlimenticios", Name = "DeleteCostosAlimenticios")]
    public async Task<IActionResult> DeleteCostosAlimenticios()
    {
        return await _costosHigieneServices.DeleteCostosAlimenticios() ? Ok() : NotFound();
    }
}