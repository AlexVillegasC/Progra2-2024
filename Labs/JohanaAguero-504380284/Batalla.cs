<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace Lab1.JohanaAguero_504380284
=======
=======
>>>>>>> b5047c9 (Lab1)
﻿using Lab1.AlexVillegas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.JohanaAguero_504380284
<<<<<<< HEAD
>>>>>>> b5047c9 (Lab1)
=======
﻿namespace Lab1.JohanaAguero_504380284
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
>>>>>>> b5047c9 (Lab1)
{
    public static class Batalla
    {

        public static string Pelear(Pokemon pok1, Pokemon pok2, bool aplicarReglasPorDebilidad)
        {


            return string.Empty;
        }
        public static string Pelear(Pokemon pok1, Pokemon pok2)
        {
            bool turnoPok1 = true; // true si es el turno de pok1, false si es el turno de pok2

            while (pok1.Vida > 0 && pok2.Vida > 0)
            {
                if (turnoPok1)
                {
                    pok2.Vida -= pok1.Ataque;
                }
                else
                {
                    pok1.Vida -= pok2.Ataque;
                }

                turnoPok1 = !turnoPok1; // Cambiar de turno
            }

            if (pok1.Vida <= 0)
            {
                return pok2.Nombre;
            }
            else
            {
                return pok1.Nombre;
            }
            return "Ganador";
        }
    }
}
