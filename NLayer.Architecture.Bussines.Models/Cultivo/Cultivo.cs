

namespace NLayer.Architecture.Bussines.GestorRiego;

public class Cultivo
{
    public int id {  get; set; }
    public string Nombre { get; set; }
    public string tipoCultivo { get; set; }
    public DateTime fechaPlantacion { get; set; }
    public string frecuenciaRiego { get; set; }

}
