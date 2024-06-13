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

        //   - GET
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

        //   - PUT
        
        public async Task<bool> UpdateTemperatures(Temperatura temperatura)
        {


            try
            {
                await WriteJsonFileAsync(_tempetaruraVirtualPath, temperatura);
                return true;
            }
            catch (Exception genericException)
            {
                return false;
            };
        }

        public async Task<bool> UpdateMoisture(HumedadSuelo humedad)
        {


            try
            {
                await WriteJsonFileAsync(_humedadadSueloVirtualPath, humedad);
                return true;
            }
            catch (Exception genericException)
            {
                return false;
            };
        }

        public async Task<bool> UpdateCultivo(Cultivo cultivo)
        {


            try
            {

                await WriteJsonFileAsync(_cultivo, cultivo);

                return true;
            }
            catch (Exception genericException)
            {
                return false;
            };
        }




        //   - DELETE
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

