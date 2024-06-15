namespace NLayer.Architecture.Bussines.GestionPlantaciones;

public class GestionPlantaciones
{
    public string Nombre { get; set; } = "Reporte de Plantaciones";

    public ControlPlagas Plagas { get; set;}


    public ControlAbono Abono { get; set; }

    public ArbolFrutal Arbol { get; set; }

}


