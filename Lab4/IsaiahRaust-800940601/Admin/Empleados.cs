namespace Lab4.IsaiahRaust.Admin
{
    public class Empleados
    {

        public string Codigo { get; set; }

        public Empleados(string codigo) { Codigo = codigo; }

        public override string ToString()
        {
            return $"Codigo de empleado: {Codigo}";
        }

    }

}
