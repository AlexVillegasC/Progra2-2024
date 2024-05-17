using System;

namespace NLayer.Architecture.Bussines.Services;

public interface IReporteClimaService
{
    Task<ReporteClima.ReporteClima> GetPronostico();
}
