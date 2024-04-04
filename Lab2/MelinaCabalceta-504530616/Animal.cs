using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.MelinaCabalceta_504530616
{
    public abstract class Animal
    {
        
        
    public string Nombre { get; set; }
    public string Color { get; set; }


    //Constructor
    public Animal(string nombre, string color)
    {
         this.Nombre = nombre;
         this.Color = color;
    }


    //Método abstracto que debe ser implementado por las subclases
            public abstract void HacerSonido();


    //Método no abstracto con una implementacion concreta

      public void MostrarTipo(string tipo)
      {
                Console.WriteLine($"Este animal, {Nombre}, es un {tipo}.");
      }
     


    }
}
