﻿
using NLayer.Architecture.Bussines.ReporteInventario;

namespace NLayer.Architecture.Bussines.Services;

public interface IReporteInventarioService
{
    
    Task<ReporteInventario.ReporteInventario> GetInventario();

    Task AddMaquinarias(Maquinaria maquinaria);

    Task<bool> UpdateMaquinaria(IEnumerable<Maquinaria> maquinaria);

    Task<bool> DeleteMaquinaria();







    Task AddMantenimiento(Mantenimiento mantenimiento);

    Task<bool> UpdateMantenimiento(IEnumerable<Mantenimiento> mantenimiento);

    Task<bool> DeleteMantenimiento();





}

//ACA HACEN LO MISMO CON SUS CLASES.