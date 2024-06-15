namespace Lab1.Danny_Abarca_504000385
{
    internal class Batalla
    {
        public static string Pelear(Pokemon Pokemon1, Pokemon Pokemon2)
        {
            bool turnoPok1 = true;
            Random rnd = new Random();

            while (Pokemon1.Vida > 0 && Pokemon2.Vida > 0)
            {
                if (turnoPok1)
                {
                    int randomNumber = rnd.Next(1, 4);

                    if (randomNumber == Pokemon2.Defensa)
                    {
                        Console.WriteLine(Pokemon2.Nombre + " ha logrado esquivar el ataque, no recibe daño en sus puntos de ataque");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(Pokemon2.Nombre + " ha recivido una ataque directo de " + Pokemon1.Nombre + " y tiene un rebajo de " + Pokemon1.Ataque + " en la vida");
                        Console.ReadKey();

                        Pokemon2.Vida -= Pokemon1.Ataque;

                        Console.WriteLine(Pokemon2.Nombre + " ha quedado con " + Pokemon2.Vida + " puntos de vida");
                        Console.ReadKey();

                    }
                }

                else
                {
                    int randomNumber = rnd.Next(1, 4);

                    if (randomNumber == Pokemon1.Defensa)
                    {
                        Console.WriteLine(Pokemon1.Nombre + " ha logrado esquivar el ataque, no recibe daño en sus puntos de ataque");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(Pokemon1.Nombre + " ha recivido una ataque directo de " + Pokemon2.Nombre + " y tiene un rebajo de " + Pokemon2.Ataque + " en la vida");
                        Console.ReadKey();

                        Pokemon1.Vida -= Pokemon2.Ataque;

                        Console.WriteLine(Pokemon1.Nombre + " ha quedado con " + Pokemon1.Vida + " puntos de vida");
                        Console.ReadKey();
                    }
                }

                turnoPok1 = !turnoPok1;
            }

            if (Pokemon1.Vida <= 0)
            {
                Console.WriteLine("<------El ganador es----->");
                return Pokemon2.Nombre;
            }
            else
            {
                Console.WriteLine("<------El ganador es----->");
                return Pokemon1.Nombre;
            }
        }
    }
}
