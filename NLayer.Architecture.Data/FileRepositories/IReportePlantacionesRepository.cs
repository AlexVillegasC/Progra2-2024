<<<<<<< HEAD
﻿using NLayer.Architecture.Bussines.GestionPlantaciones;
using NLayer.Architecture.Bussines.GestionPlantaciones;

namespace DataAccess.Layer.FileRepositories;

public interface IReportePlantacionesRepository
{
    Task<ControlPlagas> GetControlPlagas();

    //Sus Partes.... igual que arriba 

    Task<ControlAbono> GetControlAbono();


    Task<ArbolFrutal> GetArbolFrutal();
}

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Architecture.Data.FileRepositories
{
    internal class IReportePlantacionesRepository
    {
    }
}
>>>>>>> 60d7325 (Carpeta y 2 clases nuevas)
