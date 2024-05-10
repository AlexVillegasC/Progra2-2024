﻿using NLayer.Architecture.Bussines.ReporteClima;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteClimaRepository
{
    Task<List<Temperature>> GetTemperatures();
    Task AddTemperatures(Temperature temperature);

    Task<List<Wind>> GetWinds();

    Task<List<Moisture>> GetMoisture();
}