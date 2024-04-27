
namespace Lab2.DannyAbarca;
public class Fumables : ProductosCanabicos
{
    public Fumables(string NombreArticulo, int NivelTHC, int NivelCBD, int Precio) : base(NombreArticulo, NivelTHC, NivelCBD, Precio)
    {
    }

    public override void TipodeArticulo()
    {
        Console.WriteLine("En esta seccion se encontraran diversos productos fumables a base de canabis y weed misma, los cuales te permiten sentir una variedad de viajes a tu gusto.");
    }
}