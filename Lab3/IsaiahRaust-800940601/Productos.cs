namespace Lab3.IsaiahRaust
{
    public class Productos
    {

        public string Nombre { get; set; }

        public int Precio { get; set; }

        public string Codigo { get; set; }

        protected Productos(string nombre, int precio, string codigo)
        {

            this.Nombre = nombre;
            this.Precio = precio;
            this.Codigo = codigo;

        }


    }
}