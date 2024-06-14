namespace Lab5.Danny_Alvarado_504000385.Composicion;

public class Manual
    {
        public string Idioma { get; set; }
        public int Paginas { get; set; }

        public Manual(string idioma, int paginas)
        {
            Idioma = idioma;
            Paginas = paginas;
        }

        public override string ToString()
        {
            return $"Idioma: {Idioma}, Páginas: {Paginas}";
        }
    }


