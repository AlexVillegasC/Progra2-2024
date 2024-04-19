using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.AxelBadilla_504430558
{
    public class Batalla
    {

        public static string Pelea(Pokemon Pikachu, Pokemon Greninja)
        {

            int PikachuTurno = 1;
            var ganador = "";


            while (Pikachu.Vida > 0 && Greninja.Vida > 0) {

                if (PikachuTurno != 0) {

                    Greninja.Vida -= Pikachu.Ataque;
                     
                    Console.WriteLine("La vida restante de Greninja es : " + Greninja.Vida);
                    
                    } 
                    else 
                    {

                        Pikachu.Vida -= Greninja.Ataque;
                        Console.WriteLine("La vida restante de Pikachu es: " + Pikachu.Vida);
                    }

                    PikachuTurno = 1 - PikachuTurno;


                    if (Greninja.Vida <= 0) {

                        ganador = Pikachu.Nombre;
                        return ganador;
                    }
                    else if (Pikachu.Vida <= 0) {

                        ganador = Greninja.Nombre;
                        return ganador;
                    }
                }
                return ganador;


                

            }



        }




    }






    

