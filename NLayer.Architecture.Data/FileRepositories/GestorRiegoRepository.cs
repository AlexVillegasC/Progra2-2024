using Microsoft.Extensions.Configuration;
using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.GestorRiego;
using NLayer.Architecture.Data;

namespace NLayer.Architecture.Bussines.Services


{
    public class GestorRiegoRepository : FileRepository, IGestorRiegoRepository
    {
        private string _tempetaruraVirtualPath = "temperatura.json";
        private string _cultivo = "cultivo.json";
        private string _humedadadSueloVirtualPath = "humedadSuelo.json";

        private string FolderPath { get; set; }


        public GestorRiegoRepository(IConfiguration Configuration)
        {


            FolderPath = $"{Configuration["Folders:Cultivo"]}";
            _tempetaruraVirtualPath = FolderPath + _tempetaruraVirtualPath;
            _cultivo = FolderPath + _cultivo;
            _humedadadSueloVirtualPath = FolderPath + _humedadadSueloVirtualPath;

        }
        public async Task<Temperatura> GetTemperatures()
        {
            return await ReadJsonFileAsync<Temperatura>(_tempetaruraVirtualPath);
        }

        public async Task<Cultivo> GetCultivo()
        {
            return await ReadJsonFileAsync<Cultivo>(_cultivo);
        }

        public async Task<HumedadSuelo> GetMoisture()
        {
            return await ReadJsonFileAsync<HumedadSuelo>(_humedadadSueloVirtualPath);
        }

        public async Task<bool> DeleteTemperatures()
        {
            List<Temperatura> empty = new();

            try
            {
                await WriteJsonFileAsync(_tempetaruraVirtualPath, empty);
                return true;

            }catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<bool> DeleteCultivo()
        {
            List<Cultivo> empty = new();

            try
            {
                await WriteJsonFileAsync(_cultivo, empty);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public async Task<bool> DeleteMoisture()
        {
            List<HumedadSuelo> empty = new();

            try
            {
                await WriteJsonFileAsync(_humedadadSueloVirtualPath, empty);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }

      

    }

