namespace NLayer.Architecture.Bussines.Services;


public interface IGestionRiegoService
{
    Task<GestionRiego.GestionRiego> GetEstadoRiego();
}
