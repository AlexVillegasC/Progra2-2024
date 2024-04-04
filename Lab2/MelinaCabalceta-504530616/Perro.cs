using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.MelinaCabalceta_504530616
{
    public class Perro : Animal
    {
    // Constructor
      public Perro(string nombre, string color) : base(nombre, color)
      {
      }

    //Implementacion del método abstracto Hacersonido
      public override void HacerSonido()
      {
            Console.WriteLine("Guau");
      }

    }
}
