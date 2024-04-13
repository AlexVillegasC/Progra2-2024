namespace Lab4.MariaGonzalez;

public class Celular
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public decimal Precio { get; set; }

    public Celular(string marca, string modelo, decimal precio)
    {
        Marca = marca;
        Modelo = modelo;
        Precio = precio;
    }
}
