using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2.ArianaHernandez_504520730
{
    public class Pikachu : Pokemon
    {
        public Pikachu(int ataque, int vida, string nombre, int nivel) : base(ataque, vida, nombre, nivel)
        {
        }

        public override void MovimientoEspecial()
        {
            Console.WriteLine("Pikachu usa Rayo!");
        }

        public override void Presentacion()
        {
            base.Presentacion(); 
            Console.WriteLine($"{Nombre} ha entrado en el campo con mucha energía.");
        }
    }
}
