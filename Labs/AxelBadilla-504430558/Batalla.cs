namespace Lab1.AxelBadilla_504430558
{
    public class Batalla
    {

        public void Batallar(Pokemon Pikachu, Pokemon Greninja)
        {


            while (Pikachu.Vida > 0 && Greninja.Vida > 0)
            {

                Greninja.Vida -= Pikachu.Ataque;
                if (Greninja.Vida <= 0)
                {
                    Console.WriteLine($"Greninja fue debilitado!");
                    Console.WriteLine($"Pikachu ha ganado el combate");

                    break;
                }

                Console.WriteLine($"Turno finalizado!");


                Pikachu.Vida -= Greninja.Ataque;

                if (Pikachu.Vida <= 0)
                {

                    Console.WriteLine($"Pikachu se ha debilidado!");
                    Console.WriteLine($"Greninja ha ganado el combate!");

               break;

                }

                Console.WriteLine($"Turno finalizado!");

            }

        }

    }
}




