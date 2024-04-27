using System.Xml.Linq;

namespace Lab4.DiegoGutierrez_504560809.Objetos
{
    public class Mts
    {
        public string Nombre { get; set; }

        public Mts(string nombre)
        {
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}";
        }
    }
}
