
namespace Lab1.OrlandoBaltodano;

public static class Batalla
{

    public static string Modo_Batalla(Pokemon pikachu, Pokemon gengar, bool ventajaAleatoria)
    {

        ventajaAleatoria = true;

        int numRand = new Random().Next(1, 3);


        int turno = 1;


        while (pikachu.Vida > 0 && gengar.Vida > 0)
        {
            if (turno == 1)
            {
                Console.WriteLine("El turno es de pikachu!!\n");
                Console.WriteLine("Pikachu ataca...\n");
                gengar.Vida -= pikachu.Ataque + 20;
                Console.WriteLine("La vida de gengar es de: " + gengar.Vida + "\n");
                turno = 2;

            }
            else if (turno == 2)
            {
                Console.WriteLine("El turno es de gengar!!\n");
                Console.WriteLine("Gengar ataca...\n");
                pikachu.Vida -= gengar.Ataque + 20;
                Console.WriteLine("La vida de pikachu es de: " + pikachu.Vida + "\n");
                turno = 2;
            }

        }
        if (pikachu.Vida <= 0)
        {
            return gengar.Nombre;
        }
        else if (gengar.Vida <= 0)
        {
            return pikachu.Nombre;
        }

        return "";
    }

    public static string Modo_Batalla(Pokemon pikachu, Pokemon gengar)
    {
        int turno = 1;
    

        while (pikachu.Vida > 0 && gengar.Vida > 0)
        {
            if (turno == 1)
            {
                Console.WriteLine("El turno es de pikachu!!\n");
                Console.WriteLine("Pikachu ataca...\n");
                gengar.Vida -= pikachu.Ataque;
                Console.WriteLine("La vida de gengar es de: " + gengar.Vida + "\n");
                turno = 2;
                
            }
            else if (turno == 2)
            {
                Console.WriteLine("El turno es de gengar!!\n");
                Console.WriteLine("Gengar ataca...\n");
                pikachu.Vida -= gengar.Ataque;
                Console.WriteLine("La vida de pikachu es de: " + pikachu.Vida + "\n"); 
                turno = 2;
            }

        }
        if (pikachu.Vida <= 0)
        {
            return gengar.Nombre;
        }
        else if (gengar.Vida <= 0)
        {
            return pikachu.Nombre;
        }

        return "";

    }
}
