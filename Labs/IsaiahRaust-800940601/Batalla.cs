namespace Lab1.IsaiahRaust;

public class Batalla
{
    public string Pelear(Pokemon pok1, Pokemon pok2)
    {


        // Definir turno
        // 1 Cambiar de turno mientras uno de los pokemon siga con vida
        // 1.1 Si es turno del pok1, entonces la vida de pok2.vida = pok2.vida - pok1.ataque
        // 1.2 Si es turno del pok2, entonces la vida de pok1.vida = pok1.vida - pok2.ataque

        // 2 Si la vida de pok1 es <0 0, entonces ganador es pok2
        // 3 Else ganador es pok1
        // 4 Retornar nombre del pokemon

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

        return "Ganador!";

    }

}
