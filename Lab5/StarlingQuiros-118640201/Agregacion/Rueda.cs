using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.StarlingQuiros_118640201.Agregacion
{
    internal class Rueda { 
            public string Marca { get; set; }

            public Rueda(string marca)
            {
                Marca = marca;
            }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Rueda Marca: {Marca}");
            }
        }
}
