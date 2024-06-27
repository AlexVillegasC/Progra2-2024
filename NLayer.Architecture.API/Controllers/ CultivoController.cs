using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.GestionCultivo;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CultivosController : ControllerBase
{
    private readonly ICultivoService _cultivoService;

    public CultivosController(ICultivoService cultivoService)
    {
        _cultivoService = cultivoService;
    }


    [HttpGet]
    public async Task<GestionCultivo> Get()
    {
        return await _cultivoService.GetCultivo();
    }


    [HttpPost("AddCultivoDatos", Name = "AddCultivoDatos")]
    public async Task AddCultivoDatos(CultivoDatos cultivoDatos)
    {
        await _cultivoService.AddCultivoDatos(cultivoDatos);
    }
    [HttpPut("ActualizarCultivoDatos", Name = "ActualizarCultivoDatos")]
    public async Task<bool> UpdateCultivoDatos(IEnumerable<CultivoDatos> cultivoDatos)
    {
        return await _cultivoService.UpdateCultivoDatos(cultivoDatos);
    }
    [HttpDelete("BorrarCultivoDatos", Name = "BorrarCultivoDatos")]
    public async Task DeleteCultivoDatos()
    {
        await _cultivoService.DeleteCultivoDatos();
    }

    [HttpPost("AddReservorio", Name = "AddReservorio")]
    public async Task AddReservorio(Reservorio reservorio)
    {
        await _cultivoService.AddReservorio(reservorio);
    }
    [HttpPut("ActualizarReservorio", Name = "ActualizarAddReservorio")]
    public async Task<bool> UpdateReservorio(IEnumerable<Reservorio> reservorio)
    {
        return await _cultivoService.UpdateReservorio(reservorio);
    }
    [HttpDelete("BorrarReservorio", Name = "BorrarReservorio")]
    public async Task DeleteReservorio()
    {
        await _cultivoService.DeleteReservorio();
    }

    [HttpPost("AddCoeficienteCultivo", Name = "AddCoeficienteCultivo")]
    public async Task AddCoeficienteCultivo(CoeficienteCultivo coeficienteCultivo)
    {
        await _cultivoService.AddCoeficienteCultivo(coeficienteCultivo);
    }
    [HttpPut("ActualizarCoeficienteCultivo", Name = "ActualizarCoeficienteCultivo")]
    public async Task<bool> UpdateCoeficienteCultivo(IEnumerable<CoeficienteCultivo> coeficienteCultivo)
    {
        return await _cultivoService.UpdateCoeficienteCultivo(coeficienteCultivo);
    }
    [HttpDelete("BorrarCoeficienteCultivo", Name = "BorrarCoeficienteCultivo")]
    public async Task DeleteCoeficienteCultivo()
    {
        await _cultivoService.DeleteCoeficienteCultivo();
    }
}