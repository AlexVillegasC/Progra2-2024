using Lab3.IsaiahRaust.Interfaz;

namespace Lab3.IsaiahRaust
{
    internal class Bebidas : Productos, IExpiracion, IBebida
    {
        public Bebidas(string nombre, int precio, string codigo) : base(nombre, precio, codigo)
        {

        }

        public string FechaExpiracion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Bebida { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void AgregarExpiracion()
        {

        }

        void AgregarTipoBebida()
        {

        }

    }
}
