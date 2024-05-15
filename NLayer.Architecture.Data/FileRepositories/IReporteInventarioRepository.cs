
using NLayer.Architecture.Bussines.ReporteInventario;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteInventarioRepository
{
    Task<Maquinaria> GetMaquinaria();
<<<<<<< HEAD
<<<<<<< HEAD

    Task<Herramientas> GetHerramientas();

    Task<Mantenimiento> GetMantenimiento();
=======
>>>>>>> 6e723fd (Creacion de los servicios de maquinaria)
=======

    Task<Herramientas> GetHerramientas();
>>>>>>> 2366e09 (Herramientas)
}
