﻿

namespace Lab1.DianaCerdas_504600379;


public class Batalla
{
    public static string Pelea(Pokemon pokemon1, Pokemon pokemon2)
    {
        int turno = 1;

        while (pokemon1.Vida > 0 && pokemon2.Vida > 0)
        {
            if (turno == 1)
            {
                pokemon1.Vida = pokemon1.Vida - pokemon2.Ataque;
                turno = 0;
            }

            else
            {
                pokemon2.Vida = pokemon2.Vida - pokemon1.Ataque;
                turno = 1;
            }
        }
        if (pokemon1.Vida <= 0)
        {
            return pokemon2.Nombre;
        }

        return pokemon1.Nombre;

    }
}
