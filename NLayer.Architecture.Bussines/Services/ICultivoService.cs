using NLayer.Architecture.Bussines.GestionCultivo;

namespace NLayer.Architecture.Bussines.Services;

public interface ICultivoService
{
    Task<GestionCultivo.GestionCultivo> GetCultivo();
}