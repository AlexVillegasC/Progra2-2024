using NLayer.Architecture.Bussines.Models.RegistroGanado;
using NLayer.Architecture.Bussines.ReporteClima;

namespace NLayer.Architecture.Data.FileRepositories
{
    public interface IReporteRegistroGanadoRepository
    {
        Task<List<RegistroVeterinario>> GetRegistroVeterinario();
        Task<List<Ganado>> GetRegistroGanado();
        Task<List<Registro_de_Vacunas>> GetRegistroVacunas();
        
        Task AddGanado (Ganado ganado);
        Task <bool> DeleteGanado ();
        Task <bool> UpdateGanado(IEnumerable<Ganado> ganado);

    }
}
