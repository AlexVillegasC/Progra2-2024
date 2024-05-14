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
        miInventario.Mantenimiento = await _inventarioRepo.GetMantenimiento();
        miInventario.Herramientas = await _inventarioRepo.GetHerramientas();
        return miInventario;
       
        
    }

    

    

    
=======
        return miInventario;
    }
<<<<<<< HEAD
>>>>>>> 6e723fd (Creacion de los servicios de maquinaria)
=======

  //  public async Task<ReporteInventario.ReporteInventario> GetInventario1()

    

    
>>>>>>> 8e85ca0 (test)
}
   




