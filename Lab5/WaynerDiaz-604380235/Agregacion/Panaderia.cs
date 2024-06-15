namespace Lab5.WaynerDiaz;
class Panaderia
{
    public string Nombre { get; set; }
    public List<Producto> Productos { get; } = new List<Producto>();

    public void AgregarProducto(Producto producto)
    {
        Productos.Add(producto);
    }

    public void MostrarProductos()
    {
        Console.WriteLine($"Productos disponibles en {Nombre}:");
        foreach (var producto in Productos)
        {
            Console.WriteLine($"Nombre: {producto.Nombre}, Precio: {producto.Precio} USD");
        }
    }
}
