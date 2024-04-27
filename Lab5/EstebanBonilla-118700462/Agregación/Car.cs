

namespace Lab5.EstebanBonilla_118700462.Agregación;}

public class Car
{
    public void Engine()

    public Engine Engine { get; set; }

    public Car()
    {
        Engine = new Engine();
    }

    public void StartEngine()
    {
        Console.WriteLine($"The car's engine has {Engine.Horsepower} horsepower.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Engine.Horsepower = 200;
        myCar.StartEngine();
    }
}
