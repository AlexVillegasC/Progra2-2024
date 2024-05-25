using Lab5.BaironFallas_118860753.Composicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.MelinaCabalceta_504530616.Composición
{
    public class Carro
    {
        public Motor Motor { get; private set; }
        public Ruedas Ruedas { get; private set; }

        public Carro()
        {
            Motor = new Motor();
            Ruedas = new Ruedas();
        }
    }

}

/*public class Program
{
    public static void Main(string[] args)
    {
        Carro carro = new Carro();
        Console.WriteLine($"El Motor del carro es de tipo: {carro.Motor.tipoMotor}");
        Console.WriteLine($"Las ruedas del carro son: {carro.Ruedas.Cantidad}");

    }
}*/



