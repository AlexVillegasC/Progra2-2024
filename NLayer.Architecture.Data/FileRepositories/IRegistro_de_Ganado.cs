using NLayer.Architecture.Bussines.Models.RegistroGanado;
namespace NLayer.Architecture.Data.FileRepositories;

public interface IRegistro_de_Ganado
{
    Task<RegistroVeterinario> GetVeterinarios();
    Task<List<RegistroGanado>> GetRegistroGanado();
    Task<List<Registro_de_Vacunas>> GetRegistroVacunas();
}
