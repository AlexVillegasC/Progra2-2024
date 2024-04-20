using System.Xml.Linq;

namespace Lab4.DiegoGutierrez_504560809.Objetos
{
    public class Bayas
    {
        public string Nombre { get; set; }
        public Bayas(string nombre)
        {
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}";
        }
    }
}
