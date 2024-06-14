﻿using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.GestorRiego;


namespace NLayer.Architecture.Bussines.Services
{

    public class GestorRiegoService : IGestorRiegoService
    {
        /// </summary>
        private readonly IGestorRiegoRepository _estadoRiegoRepo;

        public GestorRiegoService(IGestorRiegoRepository estadoRiegoRepo)
        {
            _estadoRiegoRepo = estadoRiegoRepo;
        }

        //   - GET
        public async Task<GestorRiego.GestorRiego> GetEstadoRiego()
        {
            GestorRiego.GestorRiego miEstadoRiego = new GestorRiego.GestorRiego();
            miEstadoRiego._Temperatura = await _estadoRiegoRepo.GetTemperatures();
            miEstadoRiego._HumedadSuelo = await _estadoRiegoRepo.GetMoisture();
            miEstadoRiego._Cultivo = await _estadoRiegoRepo.GetCultivo();

            return miEstadoRiego;
        }

        //POST

        public async Task AddTemperatura(Temperatura temperatura)
        {
            await _estadoRiegoRepo.AddTemperatura(temperatura);
        }

        public async Task AddHumedadSuelo(HumedadSuelo humedadSuelo)
        {
            await _estadoRiegoRepo.AddHumedadSuelo(humedadSuelo);
        }

        public async Task AddCultivo(Cultivo cultivo)
        {
            await _estadoRiegoRepo.AddCultivo(cultivo);
        }

        //   - PUT
        public async Task<bool> UpdateTemperatures(Temperatura _tempetaruraVirtualPath)
        {
            return await _estadoRiegoRepo.UpdateTemperatures(_tempetaruraVirtualPath);
        }


        public async Task<bool> UpdateMoisture(HumedadSuelo _humedadadSueloVirtualPath)
        {
            return await _estadoRiegoRepo.UpdateMoisture(_humedadadSueloVirtualPath);
        }

        public async Task<bool> UpdateCultivo(Cultivo _cultivo)
        {
            return await _estadoRiegoRepo.UpdateCultivo(_cultivo);
        }



        //   - DELETE
        public async Task<bool> DeleteTemperatura()
        {
            return await _estadoRiegoRepo.DeleteTemperatures();
        }

        public async Task<bool> DeleteMoisture()
        {
            return await _estadoRiegoRepo.DeleteMoisture();

        }

        public async Task<bool> DeleteCultivo()
        {
            return await _estadoRiegoRepo.DeleteCultivo();
        }


    }
}