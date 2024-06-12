
namespace Lab1.BrandonNunez_305370647
{
    public class Combate
    {
        public static string Pelea(Pikachu pikachu, Eevee eevee)
        {
            int Pikachu_turno = 1;
            string ganador = "";

            while (pikachu.vida > 0 && eevee.vida > 0)
            {
                if (Pikachu_turno != 0)
                {
                    eevee.vida -= pikachu.ataque;
                    Console.WriteLine("La vida de Eevee es de: " + eevee.vida);
                }
                else
                {
                    pikachu.vida -= eevee.ataque;
                    Console.WriteLine("La vida de Pikachu es de: " + pikachu.vida);
                }

                Pikachu_turno = 1 - Pikachu_turno;


                if (eevee.vida <= 0)
                {
                    ganador = "Pikachu";
                    return ganador;
                }
                else if (pikachu.vida <= 0)
                {
                    ganador = "Eevee";
                    return ganador;
                }
            }

            return ganador;
        }
    }
}
