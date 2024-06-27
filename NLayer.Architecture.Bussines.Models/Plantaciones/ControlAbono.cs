
namespace NLayer.Architecture.Bussines.GestionPlantaciones;

public class ControlAbono
{
    public string FechaApli { get; set; }

    public int Cantidad { get; set; }

    public string Tipo { get; set; }

    public static implicit operator ControlAbono(List<ControlAbono> v)
    {
        throw new NotImplementedException();
    }
}
