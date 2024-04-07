namespace Lab2.IsaiahRaust
{
    public class Circle : Shapes
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }


<<<<<<< HEAD
        //Uso de los metodos heredados, adaptado para cada figura.
=======
        //Uso de los metodos heredados, adaptado para cada figura
>>>>>>> 1ea55c1 (Entrega Lab2)
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
