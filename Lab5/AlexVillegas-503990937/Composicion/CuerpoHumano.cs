namespace Lab5.AlexVillegas_503990937.Composicion;

public class CuerpoHumano
{
    public Corazon Corazon { get; private set; }
    public Cerebro Cerebro { get; private set; }

    public CuerpoHumano()
    {
        Corazon = new Corazon();
        Cerebro = new Cerebro();
    }
}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        CuerpoHumano cuerpoHumano = new CuerpoHumano();
//        Console.WriteLine($"Función cognitiva del cerebro: {cuerpoHumano.Cerebro.FuncionCognitiva}");
//        Console.WriteLine($"Latidos por minuto del corazón: {cuerpoHumano.Corazon.LatidosPorMinuto}");
//    }
//}