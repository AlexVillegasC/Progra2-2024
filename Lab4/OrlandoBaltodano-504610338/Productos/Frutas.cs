
namespace Lab4.OrlandoBaltodano_504610338.Productos
{
    public class Frutas
    {

        public string Nombre { get; set; }
       public Frutas(string name)
        {
            this.Nombre = name;
        }
        public override string ToString()
        {
            return $"Name:  {Nombre}";
        }
    }
}
