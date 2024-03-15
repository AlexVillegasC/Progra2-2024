using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1.Melina_Cabalceta_504530616
{


    public class Program
    {
        static void Main()
        {
            Pokemon pikachu = new Pikachu(45);
            Pokemon gengar = new Gengar(44);

            Batalla.Pelear(pikachu, gengar);
        }

    }
}