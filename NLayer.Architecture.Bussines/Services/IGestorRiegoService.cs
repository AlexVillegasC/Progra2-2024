

using NLayer.Architecture.Bussines.GestorRiego;

namespace NLayer.Architecture.Bussines.Services
{
    public interface IGestorRiegoService
    {
        //   - GET
        Task<GestorRiego.GestorRiego> GetEstadoRiego();

        //   - PUT
        Task<bool> UpdateTemperatures(Temperatura _tempetaruraVirtualPath);

        Task<bool> UpdateMoisture(HumedadSuelo _humedadadSueloVirtualPath);
        Task<bool> UpdateCultivo(Cultivo _cultivo);


        //   - DELETE
        Task<bool> DeleteTemperatura();
        Task<bool>  DeleteMoisture();
        Task<bool> DeleteCultivo();

        
    }
}
                          