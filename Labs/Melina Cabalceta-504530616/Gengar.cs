<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.Melina_Cabalceta_504530616
{
    public class Gengar : Pokemon  
    {
        public Gengar(int ataque, int vida, string nombre) : base(ataque, vida, nombre)
        { 
        }
        
=======
﻿
namespace Lab1.Melina_Cabalceta_504530616
{
    public class Gengar : Pokemon // Gengar hereda de Pokemon 
    {
        public Gengar(int Ataque)
        {
            this.Ataque = Ataque;
            this.nombre = "Gengar";
            
        }

>>>>>>> ae50c84 (Lab1 batalla pokemon)
    }
}
