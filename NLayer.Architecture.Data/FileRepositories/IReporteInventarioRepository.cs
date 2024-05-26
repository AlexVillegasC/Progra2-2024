
using NLayer.Architecture.Bussines.ReporteClima;
using NLayer.Architecture.Bussines.ReporteInventario;
using System.Collections;
using System.Data.SqlTypes;

namespace DataAccess.Layer.FileRepositories;

public interface IReporteInventarioRepository
{
    // Obtiene una lista de objetos de tipo Maquinaria.
    Task<List<Maquinaria>> GetMaquinaria();

    // Agrega una nueva máquina a la lista de maquinarias.
    Task AddMaquinarias(Maquinaria maquinaria);

    // Actualiza las máquinas existentes con la información proporcionada.
    // Devuelve true si la actualización fue exitosa, de lo contrario, false.
    Task<bool> UpdateMaquinaria(IEnumerable<Maquinaria> maquinaria);

    // Elimina todas las máquinas de la lista de maquinarias.
    // Devuelve true si la eliminación fue exitosa, de lo contrario, false.
    Task<bool> DeleteMaquinaria();

    Task<Herramientas> GetHerramientas();

    Task<Mantenimiento> GetMantenimiento();
}


//ACA HACEN LO MISMO PERO EN SUS CLASES
