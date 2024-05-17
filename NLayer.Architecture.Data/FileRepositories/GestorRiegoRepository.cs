using NLayer.Architecture.Bussines.Models.Cultivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.ReporteClima;


namespace NLayer.Architecture.Data.FileRepositories
{
    public class GestorRiegoRepository : FileRepository, IGestorRiegoRepository
    {

        private string _cultivoVirtualPath = "cultivo.json";
        private string _tempetarureVirtualPath = "temperature.json";
        private string _moistureVirtualPath = "moisture.json";

        private string _foldersPath { get; set; }


        public GestorRiegoRepository(IConfiguration configuration)
        {
            _foldersPath = $"{configuration["Folders:GestorRiego"]}";
            _cultivoVirtualPath = _foldersPath + _cultivoVirtualPath;
            _tempetarureVirtualPath = _foldersPath + _tempetarureVirtualPath;
            _moistureVirtualPath = _foldersPath + _moistureVirtualPath;



        }

        public async Task<Cultivo> GetCultivo()
        {
            return await ReadJsonFileAsync<Cultivo>(_cultivoVirtualPath);
        }

        public async Task<Temperature> GetTemperatures()
        {
            return await ReadJsonFileAsync<Temperature>(_tempetarureVirtualPath);
        }

        public async Task<Moisture> GetMoisture()
        {
            return await ReadJsonFileAsync<Moisture>(_moistureVirtualPath);
        }
    }
}
