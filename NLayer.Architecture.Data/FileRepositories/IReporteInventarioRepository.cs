
using NLayer.Architecture.Bussines.ReporteInventario;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteInventarioRepository
{
    Task<Maquinaria> GetMaquinaria();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

    Task<Herramientas> GetHerramientas();
=======
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
=======

    Task<Herramientas> GetHerramientas();
>>>>>>> d564e34 (Herramientas)
=======

    Task<Mantenimiento> GetMantenimiento();
>>>>>>> 4b4602e (Creacion de los servicios, interfaces,json de la clase mantenimiento)
=======
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
=======

    Task<Herramientas> GetHerramientas();
>>>>>>> d564e34 (Herramientas)
=======

    Task<Mantenimiento> GetMantenimiento();
>>>>>>> 4b4602e (Creacion de los servicios, interfaces,json de la clase mantenimiento)
}
