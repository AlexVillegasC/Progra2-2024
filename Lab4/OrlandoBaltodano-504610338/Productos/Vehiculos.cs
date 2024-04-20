
namespace Lab4.OrlandoBaltodano_504610338.Productos
{
    public class Vehiculos
    {
        public string Nombre { get; set; }
        public Vehiculos(string name)
        {
            this.Nombre = name;
        }
        public override string ToString()
        {
            return $"Name:  { Nombre}";
        }
    }
}
