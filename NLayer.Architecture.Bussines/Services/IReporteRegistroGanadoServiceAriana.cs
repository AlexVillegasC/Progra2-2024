using NLayer.Architecture.Bussines.Models.RegistroGanado;
using NLayer.Architecture.Data.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;

public interface IReporteRegistroGanadoServiceAriana
{
    Task<RegistroGanado.LoteDeGanado> GetRegistroGanado();

    Task Add_Ganado(Ganado ganado);

    Task<bool> Update_Ganado(IEnumerable<Ganado> ganado);

    Task<bool> Delete_Ganado();
}
