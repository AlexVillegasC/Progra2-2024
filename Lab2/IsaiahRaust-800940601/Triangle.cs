namespace Lab2.IsaiahRaust
{
    public class Triangle : Shapes
    {

        private double baseLength;
        private double height;

        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }


        //Uso de los metodos heredados, adaptado para cada figura
        public override double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }

        public override double CalculatePerimeter()
        {
            return 3 * baseLength;
        }
    }
}
