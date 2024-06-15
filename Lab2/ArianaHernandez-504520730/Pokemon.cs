using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.ArianaHernandez_504520730
{
    public abstract class Pokemon
    {
        public int Ataque { get; set; }
        public int Vida { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }

        protected Pokemon(int ataque, int vida, string nombre, int nivel)
        {
            Ataque = ataque;
            Vida = vida;
            Nombre = nombre;
            Nivel = nivel;
        }

        public abstract void MovimientoEspecial();

        public virtual void Presentacion()
        {
            Console.WriteLine("¡Un nuevo Pokémon ha aparecido en el campo de batalla!");
        }
    }
}
