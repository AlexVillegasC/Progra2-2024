using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.AxelBadilla_504430558
{
    public class ReproductorAudio : IReproductorMultimedia, IDetenerReproduccion
    {
        public void Reproducir()
        {

            Console.WriteLine("Reproduciendo audio...");

        }


        public void Detener()
        {

            Console.WriteLine("Deteniendo reproduccion...");
        
        }


    }
}
