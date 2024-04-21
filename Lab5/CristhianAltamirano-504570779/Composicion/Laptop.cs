
namespace Lab5.CristhianAltamirano_504570779.Composicion;

public class Laptop
{
    public Board Board { get; private set; }

    public Pantalla Pantalla { get; private set; }

    public Ram Ram { get; private set; }

    public DiscoDuro DiscoDuro { get; private set; }

    public Procesador Procesador { get; private set; }

    public Laptop()
    {
        Board = new Board();
        Pantalla = new Pantalla();
        Ram = new Ram();
        DiscoDuro = new DiscoDuro();
        Procesador = new Procesador();
    }

    /* Complilador del codigo
     
    using Lab5.CristhianAltamirano_504570779.Composicion;

    public class Program
    {
        public static void Main(string[] args)
        {
            Laptop nuevaLaptop = new Laptop();
            Console.WriteLine($"Verificando los componentes: {nuevaLaptop.Board.Componentes}");
            Console.WriteLine($"Prendiendo la Laptop: {nuevaLaptop.Ram.Arranque}");
            Console.WriteLine($"Verificando los procesos: {nuevaLaptop.Procesador.Procesamiento}");
            Console.WriteLine($"Visualizando imagen: {nuevaLaptop.Pantalla.Visualizacion}");
            Console.WriteLine($"Almacenamiento disponible: {nuevaLaptop.DiscoDuro.Almacenamiento} GB");
        }
    } 

     */

}
