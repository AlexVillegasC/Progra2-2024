<<<<<<< HEAD
<<<<<<< HEAD
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
        reporteArbol.Arbol = await _plantaciones.GetArbolFrutal();
        return reporteArbol;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
