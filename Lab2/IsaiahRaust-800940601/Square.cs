namespace Lab2.IsaiahRaust
{
    public class Square : Shapes
    {

        private double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }


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
