namespace Lab1.BrendaEspinoza;

public class Batalla
{
    static void Main(string[] args)
    {
        Pikachu pikachu = new Pikachu(45, 100, "Pickachu");
        Snorlax snorlax = new Snorlax(44, 100, "Snorlax");

        bool turnoPickachu = true;

        while (pikachu.EstaVivo() && snorlax.EstaVivo())
        {
            if (turnoPickachu)
            {
                Console.WriteLine($"Turno de {pikachu.Nombre}:\n");
                Console.WriteLine($"Vida de {pikachu.Nombre}: {pikachu.Vida}");
                Console.WriteLine($"Vida de {snorlax.Nombre}: {snorlax.Vida}\n");

                int ataque = new Random().Next(1, pikachu.Ataque + 10);

                Console.WriteLine($"{pikachu.Nombre} ataca a {snorlax.Nombre} con {ataque} de daño.");
                snorlax.Danio(ataque);

                if (!snorlax.EstaVivo())
                {
                    Console.WriteLine($"{snorlax.Nombre} se desmayó.\n");
                    break;
                }

                turnoPickachu = false;
            }
            else
            {
                Console.WriteLine($"Turno de {snorlax.Nombre}:\n");
                Console.WriteLine($"Vida de {snorlax.Nombre}: {pikachu.Vida}");
                Console.WriteLine($"Vida de {pikachu.Nombre}: {snorlax.Vida}\n");

                int ataque = new Random().Next(1, snorlax.Ataque + 10);

                Console.WriteLine($"{snorlax.Nombre} ataca a {pikachu.Nombre} con {ataque} de daño.");
                pikachu.Danio(ataque);

                if (!pikachu.EstaVivo())
                {

                    Console.WriteLine($"{pikachu.Nombre} se desmayó.\n");
                    break;
                }

                turnoPickachu = true;

            }
        }
    }
}