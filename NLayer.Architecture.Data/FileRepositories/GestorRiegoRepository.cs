using Microsoft.Extensions.Configuration;
using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.GestorRiego;
using NLayer.Architecture.Data;

namespace NLayer.Architecture.Bussines.Services


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
        public async Task<Temperatura> GetTemperatures()
        {
            return await ReadJsonFileAsync<Temperatura>(_tempetarureVirtualPath);
        }

        public async Task<Cultivo> GetCultivo()
        {
            return await ReadJsonFileAsync<Cultivo>(_cultivo);
        }

        public async Task<HumedadSuelo> GetMoisture()
        {
            return await ReadJsonFileAsync<HumedadSuelo>(_moistureVirtualPath);
        }

    }
}
