using Microsoft.AspNetCore.Mvc;
using NLayer.Architecture.Bussines.GestorRiego;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Bussines.Services;
using NLayer.Architecture.Bussines.Models;

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
        [HttpGet("GetTemperatura", Name = "GetTemperatura")]
        public async Task<List<Temperatura>> Get()
        {
            return await _gestorRiegoService.GetTemperatures();
        }

        [HttpGet("GetMoistures", Name = "GetMoistures")]
        public async Task<List<HumedadSuelo>> GetMoistur()
        {
            return await _gestorRiegoService.GetMoistures();
        }

        [HttpGet("GetCultivo", Name = "GetCultivo")]
        public async Task<List<Cultivo>> GetCultiv()
        {
            return await _gestorRiegoService.GetCultivos();
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
        public async Task<IActionResult> UpdateTemperatures(int id, Temperatura updateTemperatura)
        {
            return await _gestorRiegoService.UpdateTemperatures(id, updateTemperatura) ? Ok() : NotFound();
        }



        [HttpPut("UpdateHumedadSuelo", Name = "UpdateHumedadSuelo")]
        public async Task<IActionResult> UpdateHumedadSuelo(int id, HumedadSuelo updateMoisture)
        {
            return await _gestorRiegoService.UpdateMoisture(id, updateMoisture) ? Ok() : NotFound();
        }

        [HttpPut("UpdateCultivo", Name = "UpdateCultivo")]
        public async Task<IActionResult> UpdateCultivo(int id, Cultivo updateCultivo)
        {
            return await _gestorRiegoService.UpdateCultivo(id, updateCultivo) ? Ok() : NotFound();
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
