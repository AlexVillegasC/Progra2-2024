using System.Globalization;

namespace Lab1.IsaiahRaust;
public static class Batalla
{

    public static int ganador;

    public static string Pelear(Pokemon pok1, Pokemon pok2, bool aplicarReglasPorDebilidad)
    {
        return string.Empty;
    }

    public static string Pelear(Pokemon pok1, Pokemon pok2)
    {
        bool turnPok1 = true;

        while (pok1.Vida > 0 && pok2.Vida > 0)
        {
            if (turnPok1)
            {
                pok2.Vida -= pok1.Ataque;
            }
            else
            {
                pok1.Vida -= pok2.Ataque;
            }

            turnPok1 = !turnPok1;
        }

        if (pok1.Vida <= 0)
        {
            return pok2.Nombre;
        }

        return pok1.Nombre;

    }

    public static void Main(string[] args)
    {
        Pikachu pikachu = new Pikachu(50, 100, "Pikachu");
        Gengar gengar = new Gengar(55, 100, "Gengar");

        string ganador = Pelear(pikachu, gengar);
        Console.WriteLine("El ganador es: " + ganador);
        Console.ReadLine();
    }
}

