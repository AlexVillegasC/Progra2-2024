using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NLayer.Architecture.Bussines.Services;

public interface IReporteInventarioRecursosServices
{

    Task<ReporteInventarioRecursos.ReporteInventarioRecursos> GetInventario();
}
