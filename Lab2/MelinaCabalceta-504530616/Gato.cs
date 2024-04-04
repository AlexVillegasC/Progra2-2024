using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.MelinaCabalceta_504530616
{
    public class Gato : Animal
    {
        public Gato(string nombre, string color) : base(nombre, color) 
        {
        }

        //Implementacion del metodo abstracto 
        public override void HacerSonido()
        {
            Console.WriteLine("¡Miau!");
        }
    }
}
