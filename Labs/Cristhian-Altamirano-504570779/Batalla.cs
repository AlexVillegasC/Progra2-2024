<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace Lab1.Cristhian_Altamirano
=======
﻿using Lab1.AlexVillegas;
using Lab1.Cristhian_Altamirano;

namespace Lab1.Cristhian_Altamirano
>>>>>>> 11e395b (test)
=======
﻿namespace Lab1.Cristhian_Altamirano
>>>>>>> 2550663 (Merge with latest Dev changes)
{
    public class Batalla
    {
        // Definir el turno
        // 1. Mientras uno de los dos Pokemones siga con vida, cambiar de turno
        // 1.1. Si es turno del Poke1, entonces la vida de poke2.vida = poke2.vida - poke1.ataque
        // 1.2. Si es turno del poke2, entonces la vida de poke1.vida = poke1.vida - poke2.ataque
        // 2. Si la vida de poke1 <= 0, entonces ganador es: poke2
        // 3. Sino ganador es poke1
        // 4. Retornar nombre del pokemon
        public static string Pelea(Pokemon gojo, Pokemon sukuna)
        {
            throw new NotImplementedException();
        }

        public void Pelea(Gojo gojo, Sukuna sukuna)
        {

            int turno = 1;

            do
            {
                if (turno == 1)
                {
                    Console.WriteLine("Turno de Gojo:");
                    sukuna.Vida -= gojo.Ataque;
                    Console.WriteLine("Sukuna pierde " + gojo.Ataque + " puntos de vida.");
                    Console.WriteLine("Vida de Sukuna: " + sukuna.Vida);
                    turno = 2;
                }
                else
                {
                    Console.WriteLine("Turno de Sukuna:");
                    gojo.Vida -= sukuna.Ataque;
                    Console.WriteLine("Gojo pierde " + sukuna.Ataque + " puntos de vida.");
                    Console.WriteLine("Vida de Gojo: " + gojo.Vida);
                    turno = 1;
                }
            } while (gojo.Vida > 0 && sukuna.Vida > 0);

            if (gojo.Vida <= 0)
            {
                Console.WriteLine("Sukuna gana la batalla!");
            }
            else
            {
                Console.WriteLine("Gojo gana la batalla!");
            }
        }
    }

    public class Batallas
    {

        public static string Pelear(Pokemon gojo, Pokemon sukuna, bool VentajaAleatoria)
        {
            throw new NotImplementedException();
        }

        public static string Pelear(Pokemon gojo, Pokemon sukuna)
        {
            // Crear una instancia de la clase Random
            Random rnd = new Random();

            // Generar un número aleatorio entre 0 y 100
            int numeroAleatorio = rnd.Next(1, 2); // El segundo parámetro es exclusivo, por lo que generará números entre 1 y 0

            if (numeroAleatorio == 1)
            {

            }

<<<<<<< HEAD
<<<<<<< HEAD
            int turno = 1;
=======
                int turno = 1;
>>>>>>> 11e395b (test)
=======
            int turno = 1;
>>>>>>> 2550663 (Merge with latest Dev changes)

            do
            {
                if (turno == 1)
                {
                    Console.WriteLine("Turno de Gojo:");
                    sukuna.Vida -= gojo.Ataque;
                    Console.WriteLine("Sukuna pierde " + gojo.Ataque + " puntos de vida.");
                    Console.WriteLine("Vida de Sukuna: " + sukuna.Vida);
                    turno = 2;
                }
                else
                {
                    Console.WriteLine("Turno de Sukuna:");
                    gojo.Vida -= sukuna.Ataque;
                    Console.WriteLine("Gojo pierde " + sukuna.Ataque + " puntos de vida.");
                    Console.WriteLine("Vida de Gojo: " + gojo.Vida);
                    turno = 1;
                }
            } while (gojo.Vida > 0 && sukuna.Vida > 0);

            if (gojo.Vida <= 0)
            {
                Console.WriteLine("Sukuna gana la batalla!");
            }
            else
            {
                Console.WriteLine("Gojo gana la batalla!");
            }

            return string.Empty;
        }
    }
}

