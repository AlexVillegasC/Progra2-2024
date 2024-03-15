using System;


namespace Lab1.Melina_Cabalceta_504530616
{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public static class Batalla
    {
        public static string Pelear(Pokemon pok1, Pokemon pok2, bool ventajaAleatoria)
        {
            if (ventajaAleatoria)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 3);
                if (randomNumber == 1)
                {
                    pok1.Ataque += 20; // Aumentar el ataque de pok1
                }
                else
                {
                    pok2.Ataque += 20; // Aumentar el ataque de pok2
                }
            }

            bool turnoPok1 = true; // true si es el turno de pok1, false si es el turno de pok2

            while (pok1.Vida > 0 && pok2.Vida > 0)
            {
                if (turnoPok1)
                {
                    pok2.Vida -= pok1.Ataque;
                    Console.WriteLine($"{pok1.Nombre} ataca a {pok2.Nombre}.");
                }
                else
                {
                    pok1.Vida -= pok2.Ataque;
                    Console.WriteLine($"{pok2.Nombre} ataca a {pok1.Nombre}.");
                }

                turnoPok1 = !turnoPok1; // Cambiar de turno
            }

            if (pok1.Vida <= 0)
            {
                return $"{pok2.Nombre} ha ganado la batalla!";
            }
            else
            {
                return $"{pok1.Nombre} ha ganado la batalla!";
            }
        }
    }


    /*public class Program
    {
        public static void Main(string[] args)
        {
            Pikachu pikachu = new Pikachu(30, 100, "Pikachu");
            Gengar gengar = new Gengar(35, 95, "Gengar");

            Console.WriteLine($"Comienza la batalla entre {pikachu.Nombre} y {gengar.Nombre}!");

            // Simular una batalla sin ventaja aleatoria
            string resultado = Batalla.Pelear(pikachu, gengar, false);
            Console.WriteLine(resultado);

            Console.WriteLine(); // Separador

            // Simular una batalla con ventaja aleatoria
            Console.WriteLine($"Comienza otra batalla entre {pikachu.Nombre} y {gengar.Nombre} con ventaja aleatoria!");
            resultado = Batalla.Pelear(pikachu, gengar, true);
            Console.WriteLine(resultado);
        }
    }*/
=======
    public class Batalla
=======
    public static class Batalla
>>>>>>> a28cecb (Batalla Pokemon)
    {
        public static string Pelear(Pokemon pok1, Pokemon pok2, bool ventajaAleatoria)
        {
            if (ventajaAleatoria)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 3);
                if (randomNumber == 1)
                {
                    pok1.Ataque += 20; // Aumentar el ataque de pok1
                }
                else
                {
                    pok2.Ataque += 20; // Aumentar el ataque de pok2
                }
            }

            bool turnoPok1 = true; // true si es el turno de pok1, false si es el turno de pok2

            while (pok1.Vida > 0 && pok2.Vida > 0)
            {
                if (turnoPok1)
                {
                    pok2.Vida -= pok1.Ataque;
                    Console.WriteLine($"{pok1.Nombre} ataca a {pok2.Nombre}.");
                }
                else
                {
                    pok1.Vida -= pok2.Ataque;
                    Console.WriteLine($"{pok2.Nombre} ataca a {pok1.Nombre}.");
                }

                turnoPok1 = !turnoPok1; // Cambiar de turno
            }

            if (pok1.Vida <= 0)
            {
                return $"{pok2.Nombre} ha ganado la batalla!";
            }
            else
            {
                return $"{pok1.Nombre} ha ganado la batalla!";
            }
        }
<<<<<<< HEAD

<<<<<<< HEAD
    
>>>>>>> 8ae0910 (Lab1 batalla pokemon)
=======
    }
>>>>>>> 384582b (Lab1 combate pokemon M)
=======
    }


    /*public class Program
    {
        public static void Main(string[] args)
        {
            Pikachu pikachu = new Pikachu(30, 100, "Pikachu");
            Gengar gengar = new Gengar(35, 95, "Gengar");

            Console.WriteLine($"Comienza la batalla entre {pikachu.Nombre} y {gengar.Nombre}!");

            // Simular una batalla sin ventaja aleatoria
            string resultado = Batalla.Pelear(pikachu, gengar, false);
            Console.WriteLine(resultado);

            Console.WriteLine(); // Separador

            // Simular una batalla con ventaja aleatoria
            Console.WriteLine($"Comienza otra batalla entre {pikachu.Nombre} y {gengar.Nombre} con ventaja aleatoria!");
            resultado = Batalla.Pelear(pikachu, gengar, true);
            Console.WriteLine(resultado);
        }
    }*/
>>>>>>> a28cecb (Batalla Pokemon)
=======
    public class Batalla
=======
    public static class Batalla
>>>>>>> a28cecb (Batalla Pokemon)
    {
        public static string Pelear(Pokemon pok1, Pokemon pok2, bool ventajaAleatoria)
        {
            if (ventajaAleatoria)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 3);
                if (randomNumber == 1)
                {
                    pok1.Ataque += 20; // Aumentar el ataque de pok1
                }
                else
                {
                    pok2.Ataque += 20; // Aumentar el ataque de pok2
                }
            }

            bool turnoPok1 = true; // true si es el turno de pok1, false si es el turno de pok2

            while (pok1.Vida > 0 && pok2.Vida > 0)
            {
                if (turnoPok1)
                {
                    pok2.Vida -= pok1.Ataque;
                    Console.WriteLine($"{pok1.Nombre} ataca a {pok2.Nombre}.");
                }
                else
                {
                    pok1.Vida -= pok2.Ataque;
                    Console.WriteLine($"{pok2.Nombre} ataca a {pok1.Nombre}.");
                }

                turnoPok1 = !turnoPok1; // Cambiar de turno
            }

            if (pok1.Vida <= 0)
            {
                return $"{pok2.Nombre} ha ganado la batalla!";
            }
            else
            {
                return $"{pok1.Nombre} ha ganado la batalla!";
            }
        }
<<<<<<< HEAD

<<<<<<< HEAD
    
>>>>>>> 8ae0910 (Lab1 batalla pokemon)
=======
    }
>>>>>>> 384582b (Lab1 combate pokemon M)
=======
    }


    /*public class Program
    {
        public static void Main(string[] args)
        {
            Pikachu pikachu = new Pikachu(30, 100, "Pikachu");
            Gengar gengar = new Gengar(35, 95, "Gengar");

            Console.WriteLine($"Comienza la batalla entre {pikachu.Nombre} y {gengar.Nombre}!");

            // Simular una batalla sin ventaja aleatoria
            string resultado = Batalla.Pelear(pikachu, gengar, false);
            Console.WriteLine(resultado);

            Console.WriteLine(); // Separador

            // Simular una batalla con ventaja aleatoria
            Console.WriteLine($"Comienza otra batalla entre {pikachu.Nombre} y {gengar.Nombre} con ventaja aleatoria!");
            resultado = Batalla.Pelear(pikachu, gengar, true);
            Console.WriteLine(resultado);
        }
    }*/
>>>>>>> a28cecb (Batalla Pokemon)
=======
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

<<<<<<< HEAD
    
>>>>>>> 8ae0910 (Lab1 batalla pokemon)
=======
    }
>>>>>>> 384582b (Lab1 combate pokemon M)
}