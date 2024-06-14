

using NLayer.Architecture.Bussines.GestorRiego;
using NLayer.Architecture.Bussines.ReporteClima;

namespace NLayer.Architecture.Bussines.Services
{
    public interface IGestorRiegoService
    {
        Task<GestorRiego.GestorRiego> GetEstadoRiego();

        Task AddTemperatura(Temperatura temperatura);

        Task AddCultivo(Cultivo cultivo);

        Task AddHumedadSuelo(HumedadSuelo humedadSuelo);

    }
}
                          