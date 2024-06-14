namespace Lab5.DannyAlvarado.Composicion;

    public class SetLego
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Caja { get; set; }
        public List<Pieza> Piezas { get; set; }
        public string Manual { get; set; }

        public SetLego(string nombre, string codigo, string caja, string manual)
        {
            Nombre = nombre;
            Codigo = codigo;
            Caja = caja;
            Piezas = new List<Pieza>();
            Manual = manual;
        }

        public void AgregarPieza(Pieza pieza)
        {
            Piezas.Add(pieza);
            Console.WriteLine($"Pieza agregada: {pieza.Tipo}, Color: {pieza.Color}");
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Set de Lego: {Nombre}");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Caja: {Caja}");
            Console.WriteLine("Piezas:");
            foreach (var pieza in Piezas)
            {
                Console.WriteLine(pieza);
            }
            Console.WriteLine($"Manual: {Manual}");
        }
    }


public class Program
{
    public static void Main(string[] args)
    {
        Caja caja = new Caja("Cartón", "30x20x10 cm");
        Manual manual = new Manual("Español", 50);

        LegoSet legoSet = new LegoSet("Star Wars X-Wing", "SWXW-001", caja, manual);

        Pieza pieza1 = new Pieza("Bloque", "Rojo");
        Pieza pieza2 = new Pieza("Bloque", "Blanco");
        Pieza pieza3 = new Pieza("Figura", "Negro");

        legoSet.AgregarPieza(pieza1);
        legoSet.AgregarPieza(pieza2);
        legoSet.AgregarPieza(pieza3);

        legoSet.MostrarDetalles();
    }
}


