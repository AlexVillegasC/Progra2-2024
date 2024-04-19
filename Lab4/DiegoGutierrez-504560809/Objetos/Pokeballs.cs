using System.Xml.Linq;

namespace Lab4.DiegoGutierrez_504560809.Objetos
{
    public class Pokeballs
    {
        public string Nombre { get; set; }

        public Pokeballs(string nombre)
        {
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}";
        }
    }
}
