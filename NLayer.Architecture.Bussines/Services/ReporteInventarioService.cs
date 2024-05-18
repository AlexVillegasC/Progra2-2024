﻿
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
=======
>>>>>>> 148fca9 (Creacion de los servicios de maquinaria)
=======
>>>>>>> b2a43cd (Creacion de los servicios, interfaces,json de la clase mantenimiento)
        miInventario.Mantenimiento = await _inventarioRepo.GetMantenimiento();
        miInventario.Herramientas = await _inventarioRepo.GetHerramientas();
<<<<<<< HEAD
=======
        miInventario.Mantenimiento = await _inventarioRepo.GetMantenimiento();
>>>>>>> d0c9cc2 (Creacion de los servicios, interfaces,json de la clase mantenimiento)
=======
>>>>>>> 13ec088 (Jhonpy)
        return miInventario;
       
        
    }

    
<<<<<<< HEAD

    

    
=======
        return miInventario;
<<<<<<< HEAD
<<<<<<< HEAD
       
        
    }
<<<<<<< HEAD
>>>>>>> 6e723fd (Creacion de los servicios de maquinaria)
=======

    public async Task<ReporteInventario.ReporteInventario> GetInventario1()
    {
        ReporteInventario.ReporteInventario miInventario = new ReporteInventario.ReporteInventario();
        miInventario.Herramientas = await _inventarioRepo.GetHerramientas();
        return miInventario;
    }
=======
>>>>>>> 13ec088 (Jhonpy)

    

    
>>>>>>> 8e85ca0 (test)
=======
=======
       
        
>>>>>>> 0d03d42 (Herramientas)
    }
<<<<<<< HEAD
>>>>>>> b9342b3 (Creacion de los servicios de maquinaria)
<<<<<<< HEAD
>>>>>>> 148fca9 (Creacion de los servicios de maquinaria)
=======
=======

    public async Task<ReporteInventario.ReporteInventario> GetInventario1()
    {
        ReporteInventario.ReporteInventario miInventario = new ReporteInventario.ReporteInventario();
        miInventario.Herramientas = await _inventarioRepo.GetHerramientas();
=======
        miInventario.Mantenimiento = await _inventarioRepo.GetMantenimiento();
>>>>>>> 4b4602e (Creacion de los servicios, interfaces,json de la clase mantenimiento)
        return miInventario;
    }
=======
>>>>>>> ba1bfd7 (Jhonpy)

    

    
>>>>>>> 2c4ee6f (test)
>>>>>>> 064f3be (test)
}
   




