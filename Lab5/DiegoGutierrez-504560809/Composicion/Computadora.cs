namespace Lab5.DiegoGutierrez_504560809.Composicion
{
    public class Computadora
    {
        public TarjetaGrafica tarjetaGrafica { get; set; }
        public Procesador procesador { get; set; }
        public Ram ram { get; set; }
        public SSD ssd { get; set; }

        public Computadora() 
        {
            tarjetaGrafica = new TarjetaGrafica();
            procesador = new Procesador();
            ram = new Ram();
            ssd = new SSD();
        }
    }

    /*public class Program
    {
        public static void Main(string[] args)
        {
            Computadora computadora = new Computadora();
            Console.WriteLine($"Procesador:      {computadora.procesador.ModeloProcesador}");
            Console.WriteLine($"Tarjeta grafica: {computadora.tarjetaGrafica.ModeloGrafica}");
            Console.WriteLine($"Ram:             {computadora.ram.CantidadRam}");
            Console.WriteLine($"SSD:             {computadora.ssd.CapacidadSSD}");
        }
    }*/
}
