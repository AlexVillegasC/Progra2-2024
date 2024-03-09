
namespace Lab1.diana;

public static class Batalla
{
    public static string iniBatalla(Pokemon pikachu, Pokemon jiggly, int turno, bool aplicarReglasPorDebilidad)
    {
        return string.Empty;
    }
    

    public static string iniBatalla(Pokemon pikachu, Pokemon jiggly)

    {

        //1.mientras uno de los dos siga con vida cambiar de turno 
        //1.2.si es turno de pikachu jiggli.vida-=pikachu.ataque
        // 1.3. si es turno de pokemon jiglly pikachu.vida-=jiggly.Ataque
        // 2. si la vida de pikachu.Vida > 0 && jiggly.Vida> 0
        //3 sino el ganador es pikachu

        int turno = 1;

        
         while (pikachu.Vida >= 0 && jiggly.Vida >= 0)
         {

            if (turno == 1)
            {
                Console.WriteLine("turno de pikachu");
                jiggly.Vida -= pikachu.Ataque;
                turno = 2;
            }//if

            else
            {
                Console.WriteLine("turno de jiggly ");
                pikachu.Vida -= jiggly.Ataque;
                turno = 1;
            }
         }

        if (pikachu.Vida <= 0) {
            return jiggly.Nombre;
        }//if

        else
        {
            return pikachu.Nombre;
        }//else
#pragma warning disable CS0162 // Unreachable code detected
        return "";
#pragma warning restore CS0162 // Unreachable code detected
    }//metodo
    
}//clase

