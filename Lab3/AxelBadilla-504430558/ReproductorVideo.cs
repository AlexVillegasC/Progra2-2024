using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.AxelBadilla_504430558
{
    public class ReproductorVideo : IReproductorMultimedia, IDetenerReproduccion
    {

        public void Reproducir()
        {

            Console.WriteLine("Reproduciendo video...");
        
        }


        public void Detener()
        {

            Console.WriteLine("Deteniendo reproduccion...");
        
        
        }



    }
}
