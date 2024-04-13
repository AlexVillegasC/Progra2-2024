namespace Lab2.JasonReyes;

public class Motocicleta : Vehiculo
{

    public Motocicleta(string marca, string modelo, string color) : base(marca, modelo, color) { }


    public override void Arrancar()
    {
        Console.WriteLine("Encendiendo motocicleta...");
    }
}
