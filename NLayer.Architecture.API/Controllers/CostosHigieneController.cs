using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

    [HttpDelete("DeleteCostoAlimenticio", Name = "DeleteCostoAlimenticio")]
    public async Task<IActionResult> DeleteCostoAlimenticio ()
    {
        return await _costosHigieneServices.DeleteCostoAlimenticio() ? Ok() : NotFound();
    }
}