using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.JasonReyes;

public static class Batalla
{
    public static string Pelea(Pokemon pok1, Pokemon pok2, bool ventajaAleatoria)
    {
        int randomNumber = new Random().Next(1, 3);
        if (randomNumber == 1)
        {
            pok1.Ataque = pok1.Ataque + 20;
        }
        else
        {
            pok2.Ataque = pok2.Ataque + 20;
        }

        bool turnoPok1 = true;

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

            turnoPok1 = !turnoPok1;
        }

        if (pok1.Vida <= 0)
        {
            return pok2.Nombre;
        }
        else
        {
            return pok1.Nombre;
        }
    }












}
