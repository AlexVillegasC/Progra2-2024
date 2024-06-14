namespace Lab5.Danny_Alvarado_504000385.Composicion;

    public class Pieza
    {
        public string Tipo { get; set; }
        public string Color { get; set; }

        public Pieza(string tipo, string color)
        {
            Tipo = tipo;
            Color = color;
        }

        public override string ToString()
        {
            return $"Tipo: {Tipo}, Color: {Color}";
        }
    }

