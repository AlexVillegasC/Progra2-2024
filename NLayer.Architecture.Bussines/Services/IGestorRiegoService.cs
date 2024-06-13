

namespace NLayer.Architecture.Bussines.Services
{
    public interface IGestorRiegoService
    {
        Task<GestorRiego.GestorRiego> GetEstadoRiego();
        Task<bool> DeleteTemperatura();
        Task<bool>  DeleteMoisture();
        Task<bool> DeleteCultivo();

        
    }
}
                          