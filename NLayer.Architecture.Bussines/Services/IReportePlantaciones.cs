using NLayer.Architecture.Bussines.GestionPlantaciones;
using NLayer.Architecture.Bussines.ReporteClima;

namespace NLayer.Architecture.Bussines.Services;

public interface IReportePlantaciones
{
    Task<List<ControlAbono>> GetControlAbono();
    Task AddControlAbono(ControlAbono abono);

    Task<GestionPlantaciones.GestionPlantaciones> GetReporte();
   
    Task<bool> UpdateControlAbono(IEnumerable<ControlAbono> abono);
    Task<bool> DeleteControlAbono();

   

 

}
