using Lab2.DannyAbarca;

namespace Lab3.DannyAbarca
{
    public class Cremas : ProductosCanabicos
    {
        public Cremas(string NombreArticulo, int NivelTHC, int NivelCBD, int Precio) : base(NombreArticulo, NivelTHC, NivelCBD, Precio)
        {
        }

        public override void TipodeArticulo()
        {
            Console.WriteLine("En esta seccion se encontraran diversas cremas corporales a base de canabis, estas permitiran ayudarte a aliviar dolencias corporales");
        }
    }
}
