<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace Lab3.MelinaCabalceta_504530616
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.MelinaCabalceta_504530616
>>>>>>> b386617 (Lab3 Interface)
=======
﻿namespace Lab3.MelinaCabalceta_504530616
>>>>>>> 2550663 (Merge with latest Dev changes)
{
    public class Guerrero
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public string Armadura { get; set; }

        protected Guerrero(string nombre, int nivel, string armadra)
        {
            Nombre = nombre;
            Nivel = nivel;
            Armadura = armadra;
        }
    }
}
