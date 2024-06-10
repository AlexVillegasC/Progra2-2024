using NLayer.Architecture.Bussines.Models.RegistroGanado;
using NLayer.Architecture.Data.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;

public interface IReporteRegistroGanadoService 
{
    Task<RegistroGanado.LoteDeGanado> GetRegistroGanado();

    Task AddGanado (Ganado ganado);

    Task <bool> UpdateGanado (IEnumerable<Ganado> ganado);

    Task <bool> DeleteGanado ();
}