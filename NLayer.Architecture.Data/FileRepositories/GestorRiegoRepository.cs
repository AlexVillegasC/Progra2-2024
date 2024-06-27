using Microsoft.Extensions.Configuration;
using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.GestorRiego;
using NLayer.Architecture.Data;
using Newtonsoft.Json;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Bussines.Models;

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
        public async Task<List<Temperatura>> GetTemperatures()
        {
            try
            {
                var temperaturas = await ReadJsonFileAsync<List<Temperatura>>(_tempetaruraVirtualPath);
                return temperaturas ?? new List<Temperatura>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer las temperaturas: {ex.Message}");
                return new List<Temperatura>();
            }
        }

        public async Task<List<HumedadSuelo>> GetMoisture()
        {
            try
            {
                var humedadSuelo = await ReadJsonFileAsync<List<HumedadSuelo>>(_humedadadSueloVirtualPath);
                return humedadSuelo ?? new List<HumedadSuelo>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer la humedad del suelo: {ex.Message}");
                return new List<HumedadSuelo>();
            }
        }

        public async Task<List<Cultivo>> GetCultivo()
        {
            try
            {
                var cultivos = await ReadJsonFileAsync<List<Cultivo>>(_cultivo);
                return cultivos ?? new List<Cultivo>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer los cultivos: {ex.Message}");
                return new List<Cultivo>();
            }
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
        public async Task<bool> UpdateTemperatures(int id, Temperatura updatedTemperatura)
        {
            if (updatedTemperatura == null)
            {
                return false;
            }

            try
            {
                var listaTemperaturas = await ReadJsonFileListAsync<Temperatura>(_tempetaruraVirtualPath);
                if (listaTemperaturas == null)
                {
                    listaTemperaturas = new List<Temperatura>();
                }

                var indice = listaTemperaturas.FindIndex(t => t.id == id);
                if (indice != -1)
                {
                    listaTemperaturas[indice] = updatedTemperatura;
                }
                else
                {
                    return false;
                }

                await WriteJsonFileAsync(_tempetaruraVirtualPath, listaTemperaturas);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }






        
        public async Task<bool> UpdateMoisture(int id, HumedadSuelo humedadSuelo)
        {
            if (humedadSuelo == null)
            {
                return false;
            }

            try
            {
                var listaHumedad = await ReadJsonFileListAsync<HumedadSuelo>(_humedadadSueloVirtualPath);
                if (listaHumedad == null)
                {
                    listaHumedad = new List<HumedadSuelo>();
                }

                var indice = listaHumedad.FindIndex(h => h.id == id);
                if (indice != -1)
                {
                    listaHumedad[indice] = humedadSuelo;
                }
                else
                {
                    return false;
                }

                await WriteJsonFileAsync(_humedadadSueloVirtualPath, listaHumedad);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       
        public async Task<bool> UpdateCultivo(int id, Cultivo cultivo)
        {
            if (cultivo == null)
            {
                return false;
            }

            try
            {
                var listaCultivos = await ReadJsonFileListAsync<Cultivo>(_cultivo);
                if (listaCultivos == null)
                {
                    listaCultivos = new List<Cultivo>();
                }

                var indice = listaCultivos.FindIndex(c => c.id == id);
                if (indice != -1)
                {
                    listaCultivos[indice] = cultivo;
                }
                  else
                  {
                    return false;
                  }

                await WriteJsonFileAsync(_cultivo, listaCultivos);
                   return true;
            }
            catch (Exception)
            {
                return false;
            }
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

