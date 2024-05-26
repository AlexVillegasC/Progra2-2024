
using NLayer.Architecture.Bussines.ReporteClima;

namespace NLayer.Architecture.Bussines.ReporteInventario;
public class ReporteInventario
{
    public string Nombre { get; set; } = "Mi Reporte del inventario de maquinaria agricola";

    public List<Maquinaria> Maquinaria { get; set; }

    public List<Mantenimiento> Mantenimiento { get; set; }

    public List<Herramientas> Herramientas { get; set; }
}
//using es la direccion de una carpeta.