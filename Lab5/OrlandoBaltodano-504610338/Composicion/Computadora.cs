

namespace Lab5.OrlandoBaltodano.Composicion;

internal class Computadora
{
    public Procesador Procesador { get; private set; }
    public TarjetaMadre TarjetaMadre { get; private set; }
    public MemoriaRam MemoriaRam { get; private set; }
    public Computadora()
    {
        Procesador = new Procesador();
        TarjetaMadre = new TarjetaMadre();
        MemoriaRam = new MemoriaRam();
    }


}
//public static void Main(string[] args)
//{
//    Computadora computadora = new Computadora();
//    Console.WriteLine($"Tipo de Procesador: {computadora.Procesador.Tipo}");
//    Console.WriteLine($"Tipo de Tarjeta Madre: {computadora.TarjetaMadre.Tipo_De_Tarjeta}");
//    Console.WriteLine($"Tipo de Memoria RAM: {computadora.MemoriaRam.Tipo_De_Memoria}");
//}
