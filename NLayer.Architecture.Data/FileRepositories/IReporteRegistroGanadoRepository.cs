using System.Collections.Generic;
using System.Threading.Tasks;
using NLayer.Architecture.Bussines.Models.RegistroGanado;

namespace NLayer.Architecture.Data.FileRepositories
{
    public interface IReporteRegistroGanadoRepository
    {
        Task<List<RegistroVeterinario>> GetRegistroVeterinario();
        Task<List<Ganado>> GetRegistroGanado();
        Task<List<Registro_de_Vacunas>> GetRegistroVacunas();
        
    }
}
