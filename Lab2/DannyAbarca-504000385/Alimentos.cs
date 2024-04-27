
namespace Lab2.DannyAbarca;
    public class Alimentos : ProductosCanabicos
    {
        public Alimentos (string NombreArticulo, int NivelTHC, int NivelCBD, int Precio) : base (NombreArticulo, NivelTHC, NivelCBD, Precio)
        {
        }

    public override void TipodeArticulo()
    {
        Console.WriteLine("En esta seccion se encontraran diversos alimentos a base de canabis, los cuales te permiten sentir un viaje mas sensitivo.");
    }
}
 