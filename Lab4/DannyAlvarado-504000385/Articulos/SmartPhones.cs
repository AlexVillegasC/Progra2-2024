namespace Lab4.DannyAlvarado_504000385.Articulos
{
    public class Smartphones
    {
        public string Nombre { get; set; }

        public Smartphones(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}";
        }
    }
}