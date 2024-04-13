namespace Lab2.JasonReyes;

public abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Color { get; set; }


    protected Vehiculo(string marca, string modelo, string color)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Color = color;
    }




    public abstract void Arrancar();

    public virtual void Conducir()
    {
        Console.WriteLine("Conduciendo...");
    }


}