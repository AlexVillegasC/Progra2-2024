<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> c2da1d8 (Merge)
=======
>>>>>>> 19da8c5 (Avance en las clases ReportePlantaciones)
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
﻿using DataAccess.Layer.FileRepositories;
>>>>>>> b370f23 (Avance en las clases ReportePlantaciones)
>>>>>>> 19da8c5 (Avance en las clases ReportePlantaciones)

namespace NLayer.Architecture.Bussines.Services;

public class ReportePlantaciones : IReportePlantaciones
{
    private readonly IReportePlantaciones _plantaciones;

    public ReportePlantaciones(IReportePlantaciones plantaciones)
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
        GestionPlantaciones.GestionPlantaciones reporte = new GestionPlantaciones.GestionPlantaciones();
        // reporte.Plagas = await _plantaciones

        return reporte;
>>>>>>> b370f23 (Avance en las clases ReportePlantaciones)
>>>>>>> 19da8c5 (Avance en las clases ReportePlantaciones)
    }
}
