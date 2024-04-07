namespace Lab2.IsaiahRaust
{
    class Display
    {
<<<<<<< HEAD

        //Main oara deplegar los resultados (Nota se que no se ocupa por que aqui se usa el sandbox)
=======
>>>>>>> 1ea55c1 (Entrega Lab2)
        static void Main(string[] args)
        {
            Shapes square = new Square(5);
            Shapes triangle = new Triangle(4, 3);
            Shapes circle = new Circle(2);

            Console.WriteLine("Square Area: " + square.CalculateArea());
            Console.WriteLine("Square Perimeter: " + square.CalculatePerimeter());
            Console.WriteLine("Triangle Area: " + triangle.CalculateArea());
            Console.WriteLine("Triangle Perimeter: " + triangle.CalculatePerimeter());
            Console.WriteLine("Circle Area: " + circle.CalculateArea());
            Console.WriteLine("Circle Perimeter: " + circle.CalculatePerimeter());
        }
    }
}
