
namespace Lab5.DanielNunez_119040930.Composicion;

public class Room
{
    public string Name { get; set; }

    public Room(string name)
    {
        Name = name;
    }

    public void Describe()
    {
        Console.WriteLine($"This is the {Name} room.");
    }
}

