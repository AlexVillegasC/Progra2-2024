namespace Lab5.MariaGonzalez;

class Perfumeria
{
    public string Nombre { get; set; }
    public List<ProductoPerfume> Perfumes { get; } = new List<ProductoPerfume>();

    public void AgregarPerfume(ProductoPerfume perfume)
    {
        Perfumes.Add(perfume);
    }

    public void MostrarPerfumes()
    {
        Console.WriteLine($"Perfumes disponibles en {Nombre}:");
        foreach (var perfume in Perfumes)
        {
            Console.WriteLine($"Nombre: {perfume.Nombre}, Precio: {perfume.Precio} USD");
        }
    }
}
