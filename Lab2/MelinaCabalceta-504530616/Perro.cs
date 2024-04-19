using System;


namespace Lab2.MelinaCabalceta_504530616
{
    public class Perro : Animal
    {
    
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
