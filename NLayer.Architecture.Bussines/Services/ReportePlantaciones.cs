<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> c2da1d8 (Merge)
=======
>>>>>>> 19da8c5 (Avance en las clases ReportePlantaciones)
=======
>>>>>>> c938080 (Merge)
=======
>>>>>>> b96c861 (Avance en las clases ReportePlantaciones)
﻿using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.GestionPlantaciones;
<<<<<<< HEAD
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
=======
>>>>>>> c57478d (final de mi parte)
=======
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
>>>>>>> c7cd049 (Proyecto 1 completado)
=======
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
=======
>>>>>>> c9e0984 (final de mi parte)
>>>>>>> 09d2633 (final de mi parte)
=======
=======
>>>>>>> debd9b1 (final de mi parte)
=======
>>>>>>> 71ea260 (Proyecto 1 completado)
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
=======
>>>>>>> c9e0984 (final de mi parte)
=======
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
>>>>>>> 6fff2b6 (Proyecto 1 completado)
<<<<<<< HEAD
>>>>>>> 29e6ff7 (Proyecto 1 completado)
=======
=======
>>>>>>> c9e0984 (final de mi parte)
<<<<<<< HEAD
>>>>>>> debd9b1 (final de mi parte)
=======
=======
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
>>>>>>> 6fff2b6 (Proyecto 1 completado)
>>>>>>> 71ea260 (Proyecto 1 completado)
        return reporteArbol;
=======
=======
>>>>>>> e98558f (Merge)
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
=======
>>>>>>> c938080 (Merge)
=======
﻿using DataAccess.Layer.FileRepositories;
>>>>>>> b370f23 (Avance en las clases ReportePlantaciones)
<<<<<<< HEAD
>>>>>>> 19da8c5 (Avance en las clases ReportePlantaciones)
=======
=======
>>>>>>> 818cb8c (Proyecto casi finalizado)
>>>>>>> caa8401 (Proyecto casi finalizado)

namespace NLayer.Architecture.Bussines.Services;

public class ReportePlantaciones : IReportePlantaciones
{
    private readonly IReportePlantacionesRepository _plantaciones;

    public ReportePlantaciones(IReportePlantacionesRepository plantaciones)
    {
<<<<<<< HEAD
>>>>>>> e98558f (Merge)
<<<<<<< HEAD
>>>>>>> c2da1d8 (Merge)
=======
=======
        _plantaciones = plantaciones;
    }

    public async Task<GestionPlantaciones.GestionPlantaciones> GetReporte()
    {
        GestionPlantaciones.GestionPlantaciones reporteArbol = new GestionPlantaciones.GestionPlantaciones();
        reporteArbol.Plagas = await _plantaciones.GetControlPlagas();

<<<<<<< HEAD
        return reporte;
>>>>>>> b370f23 (Avance en las clases ReportePlantaciones)
<<<<<<< HEAD
>>>>>>> 19da8c5 (Avance en las clases ReportePlantaciones)
=======
=======
        return reporteArbol;
>>>>>>> 818cb8c (Proyecto casi finalizado)
<<<<<<< HEAD
>>>>>>> caa8401 (Proyecto casi finalizado)
=======
=======
=======
﻿using DataAccess.Layer.FileRepositories;
>>>>>>> b370f23 (Avance en las clases ReportePlantaciones)
=======
>>>>>>> 818cb8c (Proyecto casi finalizado)

namespace NLayer.Architecture.Bussines.Services;

public class ReportePlantaciones : IReportePlantaciones
{
    private readonly IReportePlantacionesRepository _plantaciones;

    public ReportePlantaciones(IReportePlantacionesRepository plantaciones)
    {
<<<<<<< HEAD
>>>>>>> e98558f (Merge)
<<<<<<< HEAD
>>>>>>> c938080 (Merge)
=======
=======
        _plantaciones = plantaciones;
    }

    public async Task<GestionPlantaciones.GestionPlantaciones> GetReporte()
    {
        GestionPlantaciones.GestionPlantaciones reporteArbol = new GestionPlantaciones.GestionPlantaciones();
        reporteArbol.Plagas = await _plantaciones.GetControlPlagas();

<<<<<<< HEAD
        return reporte;
>>>>>>> b370f23 (Avance en las clases ReportePlantaciones)
<<<<<<< HEAD
>>>>>>> b96c861 (Avance en las clases ReportePlantaciones)
=======
=======
        return reporteArbol;
>>>>>>> 818cb8c (Proyecto casi finalizado)
>>>>>>> ab728b9 (Proyecto casi finalizado)
    }
}
