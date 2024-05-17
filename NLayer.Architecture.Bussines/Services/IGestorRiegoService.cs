namespace NLayer.Architecture.Bussines.Services;


public interface IGestorRiegoService
{
    Task<GestionRiego.GestionRiego> GetEstadoRiego();
}
