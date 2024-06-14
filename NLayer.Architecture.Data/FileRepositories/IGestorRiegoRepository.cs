﻿using NLayer.Architecture.Bussines.GestorRiego;
//using NLayer.Architecture.Bussines.ReporteClima;


namespace DataAccess.Layer.FileRepositories


{
    public interface IGestorRiegoRepository
    {
        //   - GET
        Task<Temperatura> GetTemperatures();

        Task<Cultivo> GetCultivo();

        Task<HumedadSuelo> GetMoisture();


        //POST

        Task AddTemperatura(Temperatura temperatura);

        Task AddCultivo(Cultivo cultivo);

        Task AddHumedadSuelo(HumedadSuelo humedadSuelo);



        //   - PUT

        Task<bool> UpdateTemperatures(Temperatura _tempetaruraVirtualPath);

        Task<bool> UpdateMoisture(HumedadSuelo _humedadadSueloVirtualPath);

        Task<bool> UpdateCultivo(Cultivo _cultivo);

        //   - DELETE
        Task<bool> DeleteTemperatures();

        Task<bool> DeleteCultivo();

        Task<bool> DeleteMoisture();

    }
}
