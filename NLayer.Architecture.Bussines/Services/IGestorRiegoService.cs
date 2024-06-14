

using NLayer.Architecture.Bussines.GestorRiego;
<<<<<<< HEAD
using NLayer.Architecture.Bussines.ReporteClima;
=======
>>>>>>> origin/proyecto1/GestorRiego

namespace NLayer.Architecture.Bussines.Services
{
    public interface IGestorRiegoService
    {
        //   - GET
        Task<GestorRiego.GestorRiego> GetEstadoRiego();

<<<<<<< HEAD
        Task AddTemperatura(Temperatura temperatura);

        Task AddCultivo(Cultivo cultivo);

        Task AddHumedadSuelo(HumedadSuelo humedadSuelo);

=======
        //   - PUT
        Task<bool> UpdateTemperatures(Temperatura _tempetaruraVirtualPath);

        Task<bool> UpdateMoisture(HumedadSuelo _humedadadSueloVirtualPath);
        Task<bool> UpdateCultivo(Cultivo _cultivo);


        //   - DELETE
        Task<bool> DeleteTemperatura();
        Task<bool>  DeleteMoisture();
        Task<bool> DeleteCultivo();

        
>>>>>>> origin/proyecto1/GestorRiego
    }
}
                          