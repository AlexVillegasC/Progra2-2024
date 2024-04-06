
using Lab1.ArianaHernandez;
        // Definir el turno
        // 1. Mientras uno de los dos Pokemones siga con vida, cambiar de turno
        // 1.1. Si es turno del Poke1, entonces la vida de poke2.vida = poke2.vida - poke1.ataque
        // 1.2. Si es turno del poke2, entonces la vida de poke1.vida = poke1.vida - poke2.ataque
        // 2. Si la vida de poke1 <= 0, entonces ganador es: poke2
        // 3. Sino ganador es poke1
        // 4. Retornar nombre del pokemon

namespace Lab1.ArianaHernandez
{
    public class Batalla
    {
        // Método para simular una batalla entre dos Pokemones
        public static string Pelea(Pokemon pikachu, Pokemon charmander)
        {
            int turno = 1;

            do
            {
                if (turno == 1)
                {
                    Console.WriteLine("Turno de Pikachu:");
                    charmander.PuntosDeVida -= pikachu.Ataque;
                    Console.WriteLine("Charmander pierde " + pikachu.Ataque + " puntos de vida.");
                    Console.WriteLine("Vida de Charmander: " + charmander.PuntosDeVida);
                    turno = 2;
                }
                else
                {
                    Console.WriteLine("Turno de Charmander:");
                    pikachu.PuntosDeVida -= charmander.Ataque;
                    Console.WriteLine("Pikachu pierde " + charmander.Ataque + " puntos de vida.");
                    Console.WriteLine("Vida de Pikachu: " + pikachu.PuntosDeVida);
                    turno = 1;
                }
            } while (pikachu.PuntosDeVida > 0 && charmander.PuntosDeVida > 0);

            if (pikachu.PuntosDeVida <= 0)
            {
                return "Charmander";
            }
            else
            {
                return "Pikachu";
            }
        }
    }
}
