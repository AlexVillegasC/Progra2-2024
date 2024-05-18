namespace Lab1.Jhonn_703090697
{
    public class Batalla
    {
        public static string pelea(Pokemon pikachu, Pokemon greninja)
        {
            int Pikachu_turno = 1;
            var ganador = "";

            while (pikachu.vida > 0 && greninja.vida > 0)
            {
                if (Pikachu_turno != 0)
                {
                    greninja.vida -= pikachu.ataque;
                    Console.WriteLine("La vida de Greninja es de: " + greninja.vida);
                }
                else
                {
                    pikachu.vida -= greninja.ataque;
                    Console.WriteLine("La vida de Pikachu es de: " + pikachu.vida);
                }

                Pikachu_turno = 1 - Pikachu_turno;


                if (greninja.vida <= 0)
                {
                    ganador = pikachu.Nombre;
                    return ganador;
                }
                else if (pikachu.vida <= 0)
                {
                    ganador = greninja.Nombre;
                    return ganador;
                }
            }

            return ganador;
        }
    }
}

