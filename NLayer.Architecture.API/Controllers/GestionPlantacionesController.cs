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


}