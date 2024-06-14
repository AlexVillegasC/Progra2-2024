using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.GestorRiego;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Bussines.Services;

namespace NLayer.Architecture.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GestorRiegoController : ControllerBase
    {
        private readonly IGestorRiegoService _gestorRiegoService;

        public GestorRiegoController(IGestorRiegoService gestorRiegoService)
        {
                _gestorRiegoService  = gestorRiegoService;
        }

        //  - GET
        [HttpGet]
        public async Task<GestorRiego> Get()
        {
            return await _gestorRiegoService.GetEstadoRiego();
        }

        //POST

        [HttpPost("AddTemperatura", Name = "AddTemperatura")]
        public async Task AddTemperatura(Temperatura temperatura)
        {
            
            await _gestorRiegoService.AddTemperatura(temperatura);

        }

        [HttpPost("AddCultivo", Name = "AddCultivo")]
        public async Task AddCultivo(Cultivo cultivo)
        {
           
            await _gestorRiegoService.AddCultivo(cultivo);   

        }

        [HttpPost("AddHumedadSuelo", Name = "HumedadSuelo")]
        public async Task AddHumedadSuelo(HumedadSuelo humedadSuelo)
        {
            
            await _gestorRiegoService.AddHumedadSuelo(humedadSuelo);
 
        }


        //   - PUT



        [HttpPut("UpdateTemperatura", Name = "UpdateTemperatura")]
        public async Task<IActionResult> UpdateTemperatures(Temperatura updateTemperatura)
        {
            return await _gestorRiegoService.UpdateTemperatures(updateTemperatura) ? Ok() : NotFound();
        }



        [HttpPut("UpdateMoisture", Name = "UpdateHumedadSuelo")]
        public async Task<IActionResult> UpdateHumedadSuelo(HumedadSuelo updateMoisture)
        {
            return await _gestorRiegoService.UpdateMoisture(updateMoisture) ? Ok() : NotFound();
        }

        [HttpPut("UpdateCultivo", Name = "UpdateCultivo")]
        public async Task<IActionResult> UpdateCultivo(Cultivo updateCultivo)
        {
            return await _gestorRiegoService.UpdateCultivo(updateCultivo) ? Ok() : NotFound();
        }




        //   - DELETE
        [HttpDelete("DeleteRemperatura",Name ="DeleteTemperatura")]
        public async Task<bool> DeleteTemperatura()
        {
            return await _gestorRiegoService.DeleteTemperatura();
        }

        [HttpDelete("DeleteMoisture",Name ="DeleteMoisture")]
        public async Task<bool> DeleteMoisture()
        {
            return await _gestorRiegoService.DeleteMoisture();
        }

        [HttpDelete("DeleteCultivo",Name ="DeleteCultivo")]
        public async Task<bool> DeleteCultivo()
        {
            return await _gestorRiegoService.DeleteCultivo();
        }



    }
}
