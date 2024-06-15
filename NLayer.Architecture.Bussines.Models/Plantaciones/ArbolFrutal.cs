namespace NLayer.Architecture.Bussines.GestionPlantaciones;

public class ArbolFrutal
{
    public string FechaRecolecta { get; set; }

    public string TotalSembrados { get; set; }

    public string FrutasRecolectadas { get; set; }

    public static implicit operator ArbolFrutal(List<ArbolFrutal> v)
    {
        throw new NotImplementedException();
    }
}
