<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> c2da1d8 (Merge)
﻿using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.GestionPlantaciones;
<<<<<<< HEAD

namespace NLayer.Architecture.Bussines.Services;

public class ReportePlantaciones : IReportePlantaciones
{
    private readonly IReportePlantacionesRepository _plantaciones;

    public ReportePlantaciones(IReportePlantacionesRepository plantaciones)
    {
        _plantaciones = plantaciones;
    }

    public async Task<GestionPlantaciones.GestionPlantaciones> GetReporte()
    {
        GestionPlantaciones.GestionPlantaciones reporteArbol = new GestionPlantaciones.GestionPlantaciones();
        reporteArbol.Plagas = await _plantaciones.GetControlPlagas();
        reporteArbol.Abono = await _plantaciones.GetControlAbono();
<<<<<<< HEAD
<<<<<<< HEAD
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
=======
>>>>>>> c57478d (final de mi parte)
=======
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
>>>>>>> c7cd049 (Proyecto 1 completado)
        return reporteArbol;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
﻿using DataAccess.Layer.FileRepositories;
>>>>>>> bc4f92b (Avance en las clases ReportePlantaciones)
=======
>>>>>>> f4b2036 (Proyecto casi finalizado)

namespace NLayer.Architecture.Bussines.Services;

public class ReportePlantaciones : IReportePlantaciones
{
    private readonly IReportePlantacionesRepository _plantaciones;

    public ReportePlantaciones(IReportePlantacionesRepository plantaciones)
    {
<<<<<<< HEAD
>>>>>>> 3ad396f (Merge)
=======
        _plantaciones = plantaciones;
    }

    public async Task<GestionPlantaciones.GestionPlantaciones> GetReporte()
    {
        GestionPlantaciones.GestionPlantaciones reporteArbol = new GestionPlantaciones.GestionPlantaciones();
        reporteArbol.Plagas = await _plantaciones.GetControlPlagas();

<<<<<<< HEAD
        return reporte;
>>>>>>> bc4f92b (Avance en las clases ReportePlantaciones)
=======
        return reporteArbol;
>>>>>>> f4b2036 (Proyecto casi finalizado)
=======

namespace NLayer.Architecture.Bussines.Services
{
    internal class ReportePlantaciones
    {
>>>>>>> e98558f (Merge)
>>>>>>> c2da1d8 (Merge)
    }
}
