
namespace Lab2.BrandonNunez_305370647
{
    public abstract class Figuras
    {
        public abstract double CalcularArea(); // Se define el metodo abstracto  

        public virtual void Dibujar() // Método virtual que puede ser sobrescrito por las clases derivadas
        {
            Console.WriteLine("Dibujando una figura");
        }
    }
}
