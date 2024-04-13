<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace Lab3.MelinaCabalceta_504530616
=======
=======
>>>>>>> b386617 (Lab3 Interface)
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.MelinaCabalceta_504530616
<<<<<<< HEAD
>>>>>>> b386617 (Lab3 Interface)
=======
﻿namespace Lab3.MelinaCabalceta_504530616
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
>>>>>>> b386617 (Lab3 Interface)
=======
﻿namespace Lab3.MelinaCabalceta_504530616
>>>>>>> 2550663 (Merge with latest Dev changes)
{
    public class GuerreroHabilidoso : Guerrero, IArmaCuerpoACuerpo, IArmaADistancia
    {
        public GuerreroHabilidoso(string nombre, int nivel, string armadura) : base(nombre, nivel, armadura)
        {
        }

        public void AtacarConEspada()
        {
            Console.WriteLine($"{Nombre}  ataca con su espada");
        }

        public void DispararArco()
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            Console.WriteLine($"{Nombre} ataca con su arco");
=======
            Console.WriteLine($"{Nombre} ataca con su arco" );
>>>>>>> b386617 (Lab3 Interface)
=======
            Console.WriteLine($"{Nombre} ataca con su arco");
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
            Console.WriteLine($"{Nombre} ataca con su arco" );
>>>>>>> b386617 (Lab3 Interface)
=======
            Console.WriteLine($"{Nombre} ataca con su arco");
>>>>>>> 2550663 (Merge with latest Dev changes)
        }

        static void Main(string[] args)
        {
            //Crear una instancia de un guerrero habilidoso con nivel 10
            GuerreroHabilidoso guerrero = new GuerreroHabilidoso("Drako", 10, "Acero");

            guerrero.AtacarConEspada();
            guerrero.DispararArco();

            //Mostrar el nivel del guerrero y la armadura
            Console.WriteLine($" Nivel del guerrero:{guerrero.Nivel}");
            Console.WriteLine($" Armadura del guerrero:{guerrero.Armadura}");
        }
    }
}
