namespace Lab2.IsaiahRaust
{
    public class Square : Shapes
    {

        private double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }


        //Uso de los metodos heredados, adaptado para cada figura
        public override double CalculateArea()
        {
            return sideLength * sideLength;
        }

        public override double CalculatePerimeter()
        {
            return 4 * sideLength;
        }

    }
}
