namespace Lab5.MariaGonzalez;

class Muebleria
{
    public string Nombre { get; set; }
    public List<ProductoMueble> Muebles { get; } = new List<ProductoMueble>();

    public void AgregarMueble(ProductoMueble mueble)
    {
        Muebles.Add(mueble);
    }

    public void MostrarMuebles()
    {
        Console.WriteLine($"Muebles disponibles en {Nombre}:");
        foreach (var mueble in Muebles)
        {
            Console.WriteLine($"Nombre: {mueble.Nombre}, Precio: {mueble.Precio} USD");
        }
    }
}
