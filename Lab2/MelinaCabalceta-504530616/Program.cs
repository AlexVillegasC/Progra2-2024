using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.MelinaCabalceta_504530616
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear instancias de las clases
            Perro perro = new Perro("Blacky","Labrador");
            Gato gato = new Gato("Gus", "Persa");

            perro.MostrarTipo("canino");
            gato.MostrarTipo("felino");

            perro.HacerSonido();
            gato.HacerSonido();
        }
    }
}
