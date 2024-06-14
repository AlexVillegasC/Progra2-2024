
namespace Lab2.BrandonNunez_305370647
{
    public class Circulo : Figuras
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea() // Implementación del método abstracto
        {
            return Math.PI * radio * radio;
        }

        public override void Dibujar() // Sobrescritura del método virtual
        {
            Console.WriteLine("Dibujando un círculo.");
        }
    }
}
