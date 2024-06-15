using NLayer.Architecture.Bussines.Models.RegistroGanado;
using NLayer.Architecture.Data.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;

public interface IReporteRegistroGanadoService 
{
    Task<RegistroGanado.LoteDeGanado> GetRegistroGanado();

    Task AddGanado (Ganado ganado);

    Task <bool> UpdateGanado (IEnumerable<Ganado> ganado);

    Task <bool> DeleteGanado ();

   // Task<RegistroGanado.LoteDeGanado> GetRegistroVeterinario();

    Task AddRegistroVeterinario(RegistroVeterinario registroVeterinario);

    Task<bool> UpdateRegistroVeterinario(IEnumerable<RegistroVeterinario> registroVeterinario);

    Task<bool> DeleteRegistroVeterinario();

    Task AddRegistroVacunas(Registro_de_Vacunas registro_De_Vacunas);

    Task<bool> UpdateVacunas(IEnumerable<Registro_de_Vacunas> registro_De_Vacunas);

    Task<bool> DeleteVacunas();

}
