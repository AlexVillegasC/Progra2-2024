using Lab3.IsaiahRaust.Interfaz;

namespace Lab3.IsaiahRaust
{
    internal class Materiales : Productos, IElectrodomestico, IMaterial
    {
        public Materiales(string nombre, int precio, string codigo) : base(nombre, precio, codigo)
        {
        }

        public string Electrodomestico { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Material { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void TaGElectrodomestico()
        {

        }

        void TipoMaterial()
        {

        }

    }

}