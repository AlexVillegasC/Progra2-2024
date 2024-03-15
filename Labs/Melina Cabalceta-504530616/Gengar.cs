using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.Melina_Cabalceta_504530616
{
    public class Gengar : Pokemon // Gengar hereda de Pokemon 
    {
        public Gengar(int ataque, int vida, string nombre) : base(ataque, vida, nombre)
        {
            this.Ataque = ataque;
            this.Vida = vida;
            this.Nombre = nombre;
            
        }

    }
}
