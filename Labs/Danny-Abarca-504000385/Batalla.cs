namespace Lab1.Danny_Abarca_504000385
{
    internal class Batalla
    {
        public static string Pelear(Pokemon Chikorita, Pokemon Psyduck)
        {
            bool turnoPok1 = true;
            Random rnd = new Random();

            while (Chikorita.Vida > 0 && Psyduck.Vida > 0)
            {
                if (turnoPok1)
                {
                    int randomNumber = rnd.Next(1, 4);

                    if (randomNumber == Psyduck.Defensa)
                    {
                        Console.WriteLine(Psyduck.Nombre + " ha logrado esquivar el ataque, no recibe daño en sus puntos de ataque");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(Psyduck.Nombre + " ha recivido una ataque directo de " + Chikorita.Nombre + " y tiene un rebajo de " + Chikorita.Ataque + " en la vida");
                        Console.ReadKey();

                        Psyduck.Vida -= Chikorita.Ataque;

                        Console.WriteLine(Psyduck.Nombre + " ha quedado con " + Psyduck.Vida + " puntos de vida");
                        Console.ReadKey();

                    }
                }

                else
                {
                    int randomNumber = rnd.Next(1, 4);

                    if (randomNumber == Chikorita.Defensa)
                    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                        Console.WriteLine(Chikorita.Nombre + " ha logrado esquivar el ataque, no recibe daño en sus puntos de ataque");
=======
                        Console.WriteLine( Chikorita.Nombre + " ha logrado esquivar el ataque, no recibe daño en sus puntos de ataque");
>>>>>>> 49ff694 (Lab1 Danny Abarca 504000385)
=======
                        Console.WriteLine(Chikorita.Nombre + " ha logrado esquivar el ataque, no recibe daño en sus puntos de ataque");
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
                        Console.WriteLine( Chikorita.Nombre + " ha logrado esquivar el ataque, no recibe daño en sus puntos de ataque");
>>>>>>> 49ff694 (Lab1 Danny Abarca 504000385)
                        Console.ReadKey();
                    }
                    else
                    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                        Console.WriteLine(Chikorita.Nombre + " ha recivido una ataque directo de " + Psyduck.Nombre + " y tiene un rebajo de " + Psyduck.Ataque + " en la vida");
=======
                        Console.WriteLine(Chikorita.Nombre +" ha recivido una ataque directo de " + Psyduck.Nombre + " y tiene un rebajo de " + Psyduck.Ataque + " en la vida");
>>>>>>> 49ff694 (Lab1 Danny Abarca 504000385)
=======
                        Console.WriteLine(Chikorita.Nombre + " ha recivido una ataque directo de " + Psyduck.Nombre + " y tiene un rebajo de " + Psyduck.Ataque + " en la vida");
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
                        Console.WriteLine(Chikorita.Nombre +" ha recivido una ataque directo de " + Psyduck.Nombre + " y tiene un rebajo de " + Psyduck.Ataque + " en la vida");
>>>>>>> 49ff694 (Lab1 Danny Abarca 504000385)
                        Console.ReadKey();

                        Chikorita.Vida -= Psyduck.Ataque;

                        Console.WriteLine(Chikorita.Nombre + " ha quedado con " + Chikorita.Vida + " puntos de vida");
                        Console.ReadKey();
                    }
                }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                turnoPok1 = !turnoPok1;
=======
                turnoPok1 = !turnoPok1; 
>>>>>>> 49ff694 (Lab1 Danny Abarca 504000385)
=======
                turnoPok1 = !turnoPok1;
>>>>>>> 2550663 (Merge with latest Dev changes)
=======
                turnoPok1 = !turnoPok1; 
>>>>>>> 49ff694 (Lab1 Danny Abarca 504000385)
            }

            if (Chikorita.Vida <= 0)
            {
                Console.WriteLine("<------El ganador es----->");
                return Psyduck.Nombre;
            }
            else
            {
                Console.WriteLine("<------El ganador es----->");
                return Chikorita.Nombre;
            }
        }
    }
}
