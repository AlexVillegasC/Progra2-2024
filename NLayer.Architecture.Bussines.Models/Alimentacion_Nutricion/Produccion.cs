using NLayer.Architecture.Bussines.Models.Alimentacion_Nutricion;

namespace NLayer.Architecture.Bussines.ReporteAlimentacion;

public class Produccion
{
    public string Nombre { get; set; } = "Mi reporte de Alimentacion y Nutricion de Ganado ";

    public List<Trabajadores> ListaTrabajadores { get; set;}

    public List<Animales> ListaAnimales { get; set; }

    public List<Alimentos> ListaAlimentos { get; set; }

    public double CostoTotalPorDia { get; set; }
    public double CostoTotalPorMes { get; set; }
    public void CalcularCostos()
    {
        CostoTotalPorDia = ListaAnimales.Sum(a => a.Peso) * ListaAlimentos.Sum(a => a.Costo_Unidad) + ListaTrabajadores.Sum(t => t.Costo_Planilla) / 30;
        CostoTotalPorMes = CostoTotalPorDia * 30;
    }
}