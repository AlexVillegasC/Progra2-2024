

namespace Lab1.DianaCerdas_504600379;

int turno = 1;

public  class Batalla
{
    public static string Pelea( Pokemon pokemon1, Pokemon pokemon2)
    {
        while( pokemon1.vida>0 && pokemon2.vida > 0)
        {
            if (turno == 1)
            {
                pokemon1.vida = pokemon1.vida - pokemon2.ataque;
                turno = 0;
            }

            else
            {
                pokemon2.vida = pokemon2.vida - pokemon1.ataque;
                turno = 1; 
            }
        }
        if (pokemon1.vida <= 0)
        {
            return pokemon2.nombre;
        }
        else
        {
            return pokemon1.nombre;
        }
    }
}
