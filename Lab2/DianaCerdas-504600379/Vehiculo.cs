
namespace Lab2.DianaCerdas_504600379;

public abstract class Vehiculo
{

    public string? Modelo { get; set; }
    public string? Marca { get; set; }
    public abstract void Conducir();

    public virtual void Arreglar()
    {
        Console.WriteLine("---BIENVENIDO AL TALLER--- ");
    }



}
