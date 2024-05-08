<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿using DataAccess.Layer.FileRepositories;
using NLayer.Architecture.Bussines.GestionPlantaciones;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
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
<<<<<<< HEAD
<<<<<<< HEAD
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
=======
>>>>>>> c9e0984 (final de mi parte)
=======
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
>>>>>>> 6fff2b6 (Proyecto 1 completado)
=======
>>>>>>> c9e0984 (final de mi parte)
=======
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
>>>>>>> 6fff2b6 (Proyecto 1 completado)
=======
>>>>>>> c9e0984 (final de mi parte)
=======
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
>>>>>>> 6fff2b6 (Proyecto 1 completado)
=======
>>>>>>> c9e0984 (final de mi parte)
=======
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
>>>>>>> 6fff2b6 (Proyecto 1 completado)
        return reporteArbol;
=======
=======
>>>>>>> e98558f (Merge)
=======
>>>>>>> e98558f (Merge)
=======
>>>>>>> e98558f (Merge)
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
<<<<<<< HEAD
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
=======
        return reporteArbol;
>>>>>>> 818cb8c (Proyecto casi finalizado)
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
=======
        return reporteArbol;
>>>>>>> 818cb8c (Proyecto casi finalizado)
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
=======
        return reporteArbol;
>>>>>>> 818cb8c (Proyecto casi finalizado)
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
=======
        return reporteArbol;
>>>>>>> 818cb8c (Proyecto casi finalizado)
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
=======
        return reporteArbol;
>>>>>>> 818cb8c (Proyecto casi finalizado)
    }
}
