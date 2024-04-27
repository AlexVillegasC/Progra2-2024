namespace Lab5.KarinaMoreno_504520784.Agregacion;

public class Item
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public Item(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }
}

// codigo de ejecucion
/* personaje = new Personaje();

    personaje.AgregarItem(new Item(1, "Espada"));
    personaje.AgregarItem(new Item(2, "Poción"));

        foreach (var item in personaje.Items)
        {
            Console.WriteLine($"Item ID: {item.Id}, Nombre: {item.Nombre}");
        } */ 