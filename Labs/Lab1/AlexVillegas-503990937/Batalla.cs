namespace Lab1.AlexVillegas;

public static class Batalla
{

    /// <summary>
    /// Si se activa la ventaja aleatoria, unos de los 2 pokemon recibira +20 puntos de ataque extra.
    /// </summary>
    /// <param name="pok1"></param>
    /// <param name="pok2"></param>
    /// <param name="ventajaAleatoria"></param>
    /// <returns></returns>
    public static string Pelear(Pokemon pok1, Pokemon pok2, bool ventajaAleatoria)
    {
        // Tarea.
        // ventajaAleatoria == true
        // Random 1,2
        // Si el resultado aleatorio es 1, entonces, aumente el ataque de pokemon1 + 20
        // Sino, entonces, aumente el ataque de pokemon2  + 20.

        int randomNumber = new Random().Next(1, 3);
        if (randomNumber == 1)
        {
            pok1.Ataque = pok1.Ataque + 20;
        }
        else
        {
            pok2.Ataque = pok2.Ataque + 20;
        }

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
    }
}
