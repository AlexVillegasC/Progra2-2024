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


<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        //Uso de los metodos heredados, adaptado para cada figura.
=======
        //Uso de los metodos heredados, adaptado para cada figura
>>>>>>> 1ea55c1 (Entrega Lab2)
=======
        //Uso de los metodos heredados, adaptado para cada figura.
>>>>>>> 93d09d0 (Lab2)
=======
        //Uso de los metodos heredados, adaptado para cada figura
>>>>>>> 1ea55c1 (Entrega Lab2)
=======
        //Uso de los metodos heredados, adaptado para cada figura.
>>>>>>> 93d09d0 (Lab2)
=======
        //Uso de los metodos heredados, adaptado para cada figura.
>>>>>>> origin/development
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
