namespace Lab5.AlondraFlores_504590983.Composicion;

public class Arbol  
{
    public Sol Sol { get; set; }
    public Agua Agua { get; set; }  

    public Arbol()
    {
        Sol = new Sol();
        Agua = new Agua();
    }
}


//using Lab5.AlondraFlores_504590983.Composicion;

//public class Program
//{
//  public static void Main(string[] args)
//{
//  Arbol arbol = new Arbol();
//  Console.WriteLine($"Los Arboles necesitan constantemente: {arbol.Sol.Fotosintesis}");
//
//Console.WriteLine($"Los Arboles necesitan almenos: {arbol.Agua.CantAgua} litros de agua");
//  }
//}