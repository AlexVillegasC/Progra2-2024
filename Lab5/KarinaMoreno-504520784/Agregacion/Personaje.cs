namespace Lab5.KarinaMoreno_504520784.Agregacion;

public class Personaje
{
    public List<Item> items { get; set; }

    public Personaje()
    {
        items = new List<Item>();
    }

    public void AgregarItem(Item item)
    {
        items.Add(item);
    }
}