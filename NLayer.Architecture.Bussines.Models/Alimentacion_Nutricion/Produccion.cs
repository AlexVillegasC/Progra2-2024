
using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;

namespace NLayer.Architecture.Bussines.ReporteAlimentacion;

public class Produccion
{
    public string Nombre { get; set; } = "Mi reporte de Alimentacion y Nutricion de Ganado ";

    public DateOnly Date => DateOnly.FromDateTime(DateTime.Now);

    public Trabajadores Trabajadores { get; set;}





    public double CostoTotalPorDia { get; set; }
    public double CostoTotalPorMes { get; set; }
    public void CalcularCostos(Trabajadores trabajador)
    {
   //     CostoTotalPorDia = ListaAnimales.Sum(a => a.Peso) * ListaAlimentos.Sum(a => a.CostoUnidad) + trabajador.Costo_Planilla / 30;
        CostoTotalPorMes = CostoTotalPorDia * 30;
    }
}

