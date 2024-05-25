
namespace Lab5.DanielNunez_119040930.Composicion;

public class House
{
    private List<Room> rooms;

    public House()
    {
        rooms = new List<Room>();
        rooms.Add(new Room("Living"));
        rooms.Add(new Room("Bedroom"));
        rooms.Add(new Room("Kitchen"));
    }

    public void DescribeHouse()
    {
        Console.WriteLine("This house has the following rooms:");
        foreach (var room in rooms)
        {
            room.Describe();
        }
    }
}

//public class Program
//{
    //public static void Main(string[] args)
    //{
       // House myHouse = new House();
        //myHouse.DescribeHouse();
   // }
//}
