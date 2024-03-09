using System;


namespace Lab1.Melina_Cabalceta_504530616
{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f7031e9 (Lab1 batalla pokemon)
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
<<<<<<< HEAD
=======
    public static class Batalla
>>>>>>> a45588b (Batalla Pokemon)
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
    
>>>>>>> ae50c84 (Lab1 batalla pokemon)
=======
    }
>>>>>>> 7e22007 (Lab1 combate pokemon M)
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
>>>>>>> a45588b (Batalla Pokemon)
=======
    {
        public string Pelear(Pokemon pikachu, Pokemon gengar)
        {

            // Definir el turno
            // 1. Mientras uno de los 2 Pokemon siga con vida, cambiar de turno
            // 1.1. Si es turno del Poki1, entonces la vida d Poki2.vida = Poki2.vida 
            // 1.2.


            return "Ganador";
        }
    }

    
>>>>>>> 8ae0910 (Lab1 batalla pokemon)
>>>>>>> f7031e9 (Lab1 batalla pokemon)
}