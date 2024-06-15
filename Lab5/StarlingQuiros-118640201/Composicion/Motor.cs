using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.StarlingQuiros_118640201.Composicion
{
    public class Motor
    {
        public string Tipo { get; set; }

        public Motor(string tipo)
        {
            Tipo = tipo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Tipo de Motor: {Tipo}");
        }
    }

}
