using Lab3.AxelBadilla_504430558;
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
            Console.WriteLine("Reproduciendo Audio...");
        }


        public void Detener()
        {

            Console.WriteLine("Deteniendo reproduccion...");
        }
    }
}


<<<<<<< HEAD
=======

//ReproductorAudio reproductoraudio = new ReproductorAudio();
//reproductoraudio.Reproducir();
//reproductoraudio.Detener();

//ReproductorVideo reproductorvideo = new ReproductorVideo();
//reproductorvideo.Reproducir();
//reproductorvideo.Detener();
>>>>>>> 2d013a0 (lab3 AxelBadilla)
