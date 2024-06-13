
namespace Lab2.BrandonNunez_305370647
{
    public class Rectangulo : Figuras
    {
        private double longitud;
        private double ancho;

        public Rectangulo(double longitud, double ancho)
        {
            this.longitud = longitud;
            this.ancho = ancho;
        }

        public override double CalcularArea() // método abstracto
        {
            return longitud * ancho;
        }

        public override void Dibujar() // Sobrescritura del método virtual
        {
            Console.WriteLine("Dibujando un rectángulo.");
        }
    }
}
