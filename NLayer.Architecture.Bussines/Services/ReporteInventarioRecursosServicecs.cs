
using DataAccess.Layer.FileRepositories;

namespace NLayer.Architecture.Bussines.Services;

public class ReporteInventarioRecursosService : IReporteInventarioService
{
    //es un campo solo de lectura
    private readonly IReporteInventarioRepository _inventarioRepo;

    //constructor de la clase
    public ReporteInventarioRecursosService(IReporteInventarioRepository inventarioRepo)
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
        miInventario.Semillas = await _inventarioRepo.GetSemillas();
        miInventario.Pesticidas = await _inventarioRepo.GetPesticidas();
        miInventario.Fertilizantes = await _inventarioRepo.GetFertilizantes();
        return miInventario;


    }






}

