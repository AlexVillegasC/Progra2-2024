namespace Lab5.Danny_Alvarado_504000385.Agregacion;

public class LegoCollection
{
    public List<LegoSet> Sets { get; set; }

    public LegoCollection()
    {
        Sets = new List<LegoSet>();
    }

    public void AddSet(LegoSet legoSet)
    {
        Sets.Add(legoSet);
        Console.WriteLine($"Agrega un set: {legoSet.Nombre}");
    }

    public void RemoveSet(string code)
    {
        Sets.RemoveAll(s => s.Code == code);
        Console.WriteLine($"Elimina un set con el codigo: {code}");
    }

    public void DisplaySets()
    {
        Console.WriteLine("Coleccion Lego:");
        foreach (var set in Sets)
        {
            Console.WriteLine($"Nombre: {set.Nombre}, Piezas: {set.CantidadPiezas}, Codigo: {set.Codigo}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LegoSet set1 = new LegoSet("Star Wars X-Wing", 731, "SWXW-001");
        LegoSet set2 = new LegoSet("Harry Potter Hogwarts", 1290, "HPHW-002");
        LegoSet set3 = new LegoSet("Technic Car", 1580, "TCC-003");

        LegoCollection legoCollection = new LegoCollection();
        legoCollection.AddSet(set1);
        legoCollection.AddSet(set2);
        legoCollection.AddSet(set3);

        legoCollection.DisplaySets();

        legoCollection.RemoveSet("HPHW-002");

        legoCollection.DisplaySets();
    }
}
