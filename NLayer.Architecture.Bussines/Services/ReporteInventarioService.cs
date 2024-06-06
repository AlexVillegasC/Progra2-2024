
using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Bussines.ReporteInventario;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

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
        miInventario.Mantenimiento = await _inventarioRepo.GetMantenimiento();
        miInventario.Herramientas = await _inventarioRepo.GetHerramientas();

        return miInventario;
    }

    public async Task AddMaquinarias(Maquinaria maquinaria)
    {
        await _inventarioRepo.AddMaquinarias(maquinaria);
    }

    public async Task<bool> UpdateMaquinaria(IEnumerable<Maquinaria> maquinaria)
    {
        return await _inventarioRepo.UpdateMaquinaria(maquinaria);
    }

    public async Task<bool> DeleteMaquinaria()
    {
        return await _inventarioRepo.DeleteMaquinaria();
    }







    public async Task AddMantenimiento(Mantenimiento mantenimiento)
    {

        await _inventarioRepo.AddMantenimiento(mantenimiento);

    }



    public async Task<bool> UpdateMantenimiento(IEnumerable<Mantenimiento> mantenimiento)
    {

        return await _inventarioRepo.UpdateMantenimiento(mantenimiento);
    
    }



    public async Task<bool> DeleteMantenimiento()
    {

        return await _inventarioRepo.DeleteMantenimiento();
    }


    public async Task AddHerramientas(Herramientas herramientas)
    {
        await _inventarioRepo.AddHerramientas(herramientas);
    }

    public async Task<bool> UpdateHerramientas(IEnumerable<Herramientas> herramientas)
    {

        return await _inventarioRepo.UpdateHerramientas(herramientas);

    }


    public async Task<bool> DeleteHerramientas() 
    {
        return await _inventarioRepo.DeleteHerramientas();
    }

}



