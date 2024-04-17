namespace Lab4.IsaiahRaust.Admin
{
    public class Clientes
    {

        public string Nombre { get; set; }

        public Clientes(string nombre) { Nombre = nombre; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}";
        }

    }

}
