namespace Lab1.DanielNunez___119040930
{
    public class Combate
    {
        public void Pelear(Pikachu pikachu, Charizard charizard)
        {
            pikachu.Vida = 100;
            charizard.vida = 120;

            bool turno = false;
            do
            {

                if (!turno)
                {

                    charizard.Vida -= pikachu.Ataque;
                    Console.WriteLine($"Pikachu ataca a Charizard. Vida de Charizard: {charizard.Vida}");
                    turno = true;
                }
                else
                {
                    // Charizard ataca a Pikachu
                    pikachu.Vida -= charizard.Ataque;  // Aquí puede ocurrir el error CS1061
                    Console.WriteLine($"Charizard ataca a Pikachu. Vida de Pikachu: {pikachu.Vida}");
                    // Cambiar el turno a false para que sea el turno de Pikachu en la siguiente iteración
                    turno = false;
                }

            } while (pikachu.Vida > 0 && charizard.Vida > 0); // La pelea continúa mientras ambos pokemones tengan vida

            // Determinar el resultado de la pelea
            if (pikachu.Vida <= 0)
            {
                Console.WriteLine("Charizard ha ganado la pelea!");
            }
            else
            {
                Console.WriteLine("Pikachu ha ganado la pelea!");
            }
        }
    }


}
