using Lab3.IsaiahRaust.Interfaz;

namespace Lab3.IsaiahRaust
{
    internal class AlimentosFrescos : Productos, IExpiracion, IAlimento
    {
        public AlimentosFrescos(string nombre, int precio, string codigo) : base(nombre, precio, codigo)
        {

        }

        public string FechaExpiracion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Alimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void AgregarExpiracion()
        {

        }

        void AgregarTipoAlimento()
        {

        }

    }
}

