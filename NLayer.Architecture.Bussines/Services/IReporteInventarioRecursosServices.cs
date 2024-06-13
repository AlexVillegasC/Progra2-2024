using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Architecture.Bussines.ReporteInventarioRecursos;



namespace NLayer.Architecture.Bussines.Services;

public interface IReporteInventarioRecursosServices
{

    Task<ReporteInventarioRecursos.ReporteInventarioRecursos> GetInventario();

    Task AddFertilizantes(Fertilizantes fertilizantes);

    Task<bool> UpdateFertilizantes(IEnumerable<Fertilizantes> fertilizantes);

    Task<bool> DeleteFertilizantes();


    Task AddPesticidas(Pesticidas pesticidas);

    Task<bool> UpdatePesticidas(IEnumerable<Pesticidas> pesticidas);

    Task<bool> DeletePesticidas();

}
