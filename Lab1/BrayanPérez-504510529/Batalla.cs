using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.BrayanPérez_504510529
{
    internal class Batalla
    {
        public static string pelea(Pokemon articuno, Pokemon zapdos)
        {
            int Articuno_turno = 1;
            var ganador = "";

            while (articuno.Vida > 0 && zapdos.Vida > 0)
            {
                if (Articuno_turno != 0)
                {
                    articuno.Vida -= zapdos.Ataque;
                    Console.WriteLine("La vida de Articuno es de: " + articuno.Vida);
                }
                else
                {
                    zapdos.Vida -= articuno.Ataque;
                    Console.WriteLine("La vida de Zapdos es de: " + zapdos.Vida);
                }

                Articuno_turno = 1 - Articuno_turno;


                if (zapdos.Vida <= 0)
                {
                    ganador = articuno.Nombre;
                    return ganador;
                }
                else if (articuno.Vida <= 0)
                {
                    ganador = zapdos.Nombre;
                    return ganador;
                }
            }

            return ganador;
        }
    }
}
