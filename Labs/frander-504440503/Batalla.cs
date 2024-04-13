using System.Security.Cryptography.X509Certificates;

namespace Lab1.frander_504440503;

public class Batalla
{

    public static string Pelear(Pokemon poke1, Pokemon poke2)
    {

        while (poke1.Vida > 0 && poke2.Vida>0) 
        {
            int turno=1;

            if (turno == 1) // el primer turno pertence al poke1  de atacar
            {
                poke2.Vida = poke2.Vida - poke1.Ataque;
                turno = 0;
            } 

            else{
                poke1.Vida = poke1.Vida - poke2.Ataque; // turno de atacar del poke2
                turno=1;
            }
        }

        if (poke1.Vida <=0)
        {
          return poke2.Nombre; // si gana el poke2
        }
 
        else
        {
            return poke1.Nombre; // si gana el poke1 
        }

    }

}