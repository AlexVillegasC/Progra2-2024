<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 384582b (Lab1 combate pokemon M)
﻿using System;
using System.Collections.Generic;
using System.Linq;

<<<<<<< HEAD
namespace Lab1.Melina_Cabalceta_504530616
{
    public class Gengar : Pokemon  
    {
        public Gengar(int ataque, int vida, string nombre) : base(ataque, vida, nombre)
        { 
        }
        
=======
﻿
=======
>>>>>>> 384582b (Lab1 combate pokemon M)
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

>>>>>>> 8ae0910 (Lab1 batalla pokemon)
    }
}
