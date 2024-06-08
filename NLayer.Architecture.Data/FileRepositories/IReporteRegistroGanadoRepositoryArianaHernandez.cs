using NLayer.Architecture.Bussines.Models.RegistroGanado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NLayer.Architecture.Data.FileRepositories
{
    public interface IReporteRegistroGanadoRepositoryArianaHernandez
    {
        Task<List<RegistroVeterinario>> GetRegistroVeterinario();
        Task<List<Ganado>> GetRegistroGanado();
        Task<List<Registro_de_Vacunas>> GetRegistroVacunas();

        Task AddGanado(Ganado ganado);

        Task<bool> DeleteGanado();

        Task<bool> UpdateGanado(IEnumerable<Ganado> ganado);

    }
}


   