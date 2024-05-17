using Microsoft.Extensions.Configuration;
using NLayer.Architecture.Bussines.Models.Cultivo;
using NLayer.Architecture.Bussines.ReporteClima;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NLayer.Architecture.Data.FileRepositories
{
    public class GestorRiegoRepository : FileRepository, IGestorRiegoRepository
    {
        private string _tempetarureVirtualPath = "temperature.json";
        private string _cultivo = "cultivo.json";
        private string _moistureVirtualPath = "moisture.json";

        private string FolderPath { get; set; }


        public GestorRiegoRepository(IConfiguration Configuration)
        {
            FolderPath = $"{Configuration["Folders:Clima"]}";
            _tempetarureVirtualPath = FolderPath + _tempetarureVirtualPath;
            _cultivo = FolderPath + _cultivo;
            _moistureVirtualPath = FolderPath + _moistureVirtualPath;

        }
        public async Task<Temperature> GetTemperatures()
        {
            return await ReadJsonFileAsync<Temperature>(_tempetarureVirtualPath);
        }

        public async Task<Cultivo> GetCultivo()
        {
            return await ReadJsonFileAsync<Cultivo>(_cultivo);
        }

        public async Task<Moisture> GetMoisture()
        {
            return await ReadJsonFileAsync<Moisture>(_moistureVirtualPath);
        }

    }
}
