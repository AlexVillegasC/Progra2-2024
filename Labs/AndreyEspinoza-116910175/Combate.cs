
namespace Lab1.AndreyEspinoza_116910175
{
    public class Combate
    {
        public void Pelear (Arceus arceus, Moltres moltres) 
        {
            arceus.vida = 500;
            moltres.vida = 375;

            bool turno = false;
            do
            {
                if (!turno) 
                {
                    moltres.vida -= arceus.ataque;
                    Console.WriteLine($"Moltres ataca a Arceus. Vida de Arceus: {arceus.Vida}");
                    turno = true;
                }

                else
                {
                    arceus.vida -= arceus.ataque;
                    Console.WriteLine($"Arceus ataca a Moltres. Vida de Moltres: {moltres.Vida}");
                    turno = false;
                }

            } while (arceus.Vida > 0 && moltres.Vida > 0);

            if (arceus.Vida <= 0) 
            {
                Console.WriteLine("Moltres ha ganado la pelea.");
            }

            else 
            {
                Console.WriteLine("Arceus ha ganado la pelea.");
            }
        }
    }
}
