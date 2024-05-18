
using DataAccess.Layer.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;

 public class ReporteInventarioService : IReporteInventarioService
{
    //es un campo solo de lectura
    private readonly IReporteInventarioRepository _inventarioRepo;

    //constructor de la clase
    public ReporteInventarioService(IReporteInventarioRepository inventarioRepo)
    {
        _inventarioRepo = inventarioRepo;
    }

    //implementacion del metodo
    public async Task<ReporteInventario.ReporteInventario> GetInventario()
    {
        // Se crea una nueva instancia de Reporteinventario para almacenar el inventario
        ReporteInventario.ReporteInventario miInventario = new ReporteInventario.ReporteInventario();

        // Se obtienen las maquinaria relacionadas con el inventario agricola
        // utilizando el repositorio proporcionado (_inventarioRepo).
        // Como este método es asincrónico, se usa 'await' para esperar su finalización.
        miInventario.Maquinaria = await _inventarioRepo.GetMaquinaria();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        miInventario.Mantenimiento = await _inventarioRepo.GetMantenimiento();
        miInventario.Herramientas = await _inventarioRepo.GetHerramientas();
        return miInventario;
       
        
    }

<<<<<<< HEAD
<<<<<<< HEAD
    
<<<<<<< HEAD

    

    
=======
        return miInventario;
       
        
    }
<<<<<<< HEAD
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
=======

=======
>>>>>>> d564e34 (Herramientas)
    public async Task<ReporteInventario.ReporteInventario> GetInventario1()
    {
        ReporteInventario.ReporteInventario miInventario = new ReporteInventario.ReporteInventario();
        miInventario.Herramientas = await _inventarioRepo.GetHerramientas();
<<<<<<< HEAD
=======
        miInventario.Mantenimiento = await _inventarioRepo.GetMantenimiento();
>>>>>>> 4b4602e (Creacion de los servicios, interfaces,json de la clase mantenimiento)
=======
        miInventario.Mantenimiento = await _inventarioRepo.GetMantenimiento();
>>>>>>> 4b4602e (Creacion de los servicios, interfaces,json de la clase mantenimiento)
        return miInventario;
    }
<<<<<<< HEAD
=======
>>>>>>> ba1bfd7 (Jhonpy)
=======

  //  public async Task<ReporteInventario.ReporteInventario> GetInventario1()
>>>>>>> 2c4ee6f (test)
=======
        return miInventario;
    }
>>>>>>> d564e34 (Herramientas)
=======
    
>>>>>>> ba1bfd7 (Jhonpy)

    

    
<<<<<<< HEAD
>>>>>>> 2c4ee6f (test)
=======
        return miInventario;
    }
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
=======
>>>>>>> 2c4ee6f (test)
}
   




