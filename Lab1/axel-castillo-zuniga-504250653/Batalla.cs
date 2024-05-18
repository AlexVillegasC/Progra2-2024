namespace Lab1.axel_castillo_zuniga_504250653
{
    public class Batalla
    {
        public static string battle(Pikachu pikachu, Charmander charmander)
        {
            int PikachuTurno = 1;
            while (pikachu.Vida > 0 && charmander.Vida > 0)
            {
                if (PikachuTurno == 1)
                {
                    charmander.Vida -= pikachu.Ataque;
                    Console.WriteLine($"La vida restante de Charmander es: {charmander.Vida}");
                }
                else
                {
                    pikachu.Vida -= charmander.Ataque;
                    Console.WriteLine($"La vida restante de Pikachu es: {pikachu.Vida}");
                }
                PikachuTurno = (PikachuTurno + 1) % 2; // Alternar el turno entre 0 y 1
            }

            if (pikachu.Vida <= 0)
            {
                return charmander.Name;
            }
            else
            {
                return pikachu.Name;
            }
        }
    }
}
