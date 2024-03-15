using System;


namespace Lab1.Melina_Cabalceta_504530616
{
    public class Batalla
    {
        public string Pelear(Pokemon pikachu, Pokemon gengar)
        {
            bool turnopikachu = true; // true si es el turno de pikachu, false si es el turno de gengar

            while (pikachu.Vida > 0 && gengar.Vida > 0)
            {
                if (turnopikachu)
                {
                    gengar.Vida -= pikachu.Ataque;
                }
                else
                {
                    pikachu.Vida -= gengar.Ataque;
                }

                turnopikachu = !turnopikachu; // Cambiar de turno
            }

            if (pikachu.Vida <= 0)
            {
                return gengar.Nombre;
            }
            else
            {
                return pikachu.Nombre;
            }


            return "Ganador";
        }

    }
}