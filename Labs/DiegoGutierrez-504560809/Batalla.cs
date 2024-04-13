namespace Lab1.DiegoGutierrez_504560809
{
    public class Batalla
    {
        public static string Pelea(Pokemon swampert, Pokemon blaziken)
        {
            throw new NotImplementedException();
        }

        public void Pelea(Swampert swampert, Blaziken blaziken)
        {

            int turno = 1;

            do
            {
                if (turno == 1)
                {
                    Console.WriteLine("Turno de Swampert:");
                    blaziken.Vida -= swampert.Ataque;
                    Console.WriteLine("Blaziken pierde " + swampert.Ataque + " puntos de vida.");
                    Console.WriteLine("Vida de Blaziken: " + blaziken.Vida);
                    turno = 2;
                }
                else
                {
                    Console.WriteLine("Turno de Blaziken:");
                    swampert.Vida -= blaziken.Ataque;
                    Console.WriteLine("Swampert pierde " + blaziken.Ataque + " puntos de vida.");
                    Console.WriteLine("Vida de Swampert: " + swampert.Vida);
                    turno = 1;
                }
            } while (swampert.Vida > 0 && blaziken.Vida > 0);

            if (swampert.Vida <= 0)
            {
                Console.WriteLine("Blaziken gana la batalla!");
            }
            else
            {
                Console.WriteLine("Swampert gana la batalla!");
            }
        }
    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
}
=======
}

>>>>>>> b9cffe2 (lab2 pokemon)
=======
}

>>>>>>> b9cffe2 (lab2 pokemon)
=======
}
>>>>>>> origin/development
