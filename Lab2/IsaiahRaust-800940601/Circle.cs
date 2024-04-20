namespace Lab2.IsaiahRaust
{
    public class Circle : Shapes
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }


        //Uso de los metodos heredados, adaptado para cada figura.
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
