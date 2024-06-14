using Microsoft.Extensions.Configuration;
using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.GestorRiego;
using NLayer.Architecture.Data;
using Newtonsoft.Json;

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


        //POST

        public async Task AddTemperatura(Temperatura temperatura)
        {
            if (temperatura != null)
            {
                List<Temperatura> temperaturasExistentes = new List<Temperatura>();

                if (File.Exists(_tempetaruraVirtualPath))
                {
                    string json = await File.ReadAllTextAsync(_tempetaruraVirtualPath);
                    if (!string.IsNullOrEmpty(json))
                    {
                        try
                        {
                            temperaturasExistentes = JsonConvert.DeserializeObject<List<Temperatura>>(json);
                        }
                        catch (JsonSerializationException)
                        {


                            temperaturasExistentes = new List<Temperatura>();
                        }
                    }
                }


                temperaturasExistentes.Add(temperatura);

                string updatedJson = JsonConvert.SerializeObject(temperaturasExistentes, Formatting.Indented);
                await File.WriteAllTextAsync(_tempetaruraVirtualPath, updatedJson);
            }
        }

        public async Task AddCultivo(Cultivo cultivo)
        {
            if (cultivo != null)
            {
                List<Cultivo> cultivoExistentes = new List<Cultivo>();

                if (File.Exists(_cultivo))
                {
                    string json = await File.ReadAllTextAsync(_cultivo);
                    if (!string.IsNullOrEmpty(json))
                    {
                        try
                        {
                            cultivoExistentes = JsonConvert.DeserializeObject<List<Cultivo>>(json);
                        }
                        catch (JsonSerializationException)
                        {


                            cultivoExistentes = new List<Cultivo>();
                        }
                    }
                }


                cultivoExistentes.Add(cultivo);

                string updatedJson = JsonConvert.SerializeObject(cultivoExistentes, Formatting.Indented);
                await File.WriteAllTextAsync(_cultivo, updatedJson);
            }
        }


        public async Task AddHumedadSuelo(HumedadSuelo humedadSuelo)
        {
            if (humedadSuelo != null)
            {
                List<HumedadSuelo> humedadSueloExistentes = new List<HumedadSuelo>();

                if (File.Exists(_humedadadSueloVirtualPath))
                {
                    string json = await File.ReadAllTextAsync(_humedadadSueloVirtualPath);
                    if (!string.IsNullOrEmpty(json))
                    {
                        try
                        {
                            humedadSueloExistentes = JsonConvert.DeserializeObject<List<HumedadSuelo>>(json);
                        }
                        catch (JsonSerializationException)
                        {


                            humedadSueloExistentes = new List<HumedadSuelo>();
                        }
                    }
                }


                humedadSueloExistentes.Add(humedadSuelo);

                string updatedJson = JsonConvert.SerializeObject(humedadSueloExistentes, Formatting.Indented);
                await File.WriteAllTextAsync(_humedadadSueloVirtualPath, updatedJson);
            }
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

