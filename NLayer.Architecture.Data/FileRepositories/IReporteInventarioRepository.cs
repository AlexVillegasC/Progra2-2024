
using NLayer.Architecture.Bussines.ReporteInventario;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteInventarioRepository
{
    Task<Maquinaria> GetMaquinaria();
<<<<<<< HEAD
<<<<<<< HEAD

    Task<Herramientas> GetHerramientas();
=======
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
=======

    Task<Herramientas> GetHerramientas();
>>>>>>> d564e34 (Herramientas)
}
