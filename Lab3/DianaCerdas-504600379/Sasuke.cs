using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.DianaCerdas_504600379
{
    public class Sasuke : IAtaqNinjutsu, IAtaqTaijutsu, IAtaqGenjutsu
    {
        public int Vida { get; set; }
        public string Nombre { get; set; }

        protected Sasuke(int vida, string nombre)
        {
            this.Vida = vida;
            this.Nombre = nombre;

        }
        public void AtaqNinjutsu()
        {
            Console.WriteLine("esta usando ninjutsu");

        }

        public void AtaqTaijutsu()
        {
            Console.WriteLine("esta usando Taijutsu");
        }

        public void AtaqGenjutsu()
        {
            Console.WriteLine("esta usando Genjutsu");
        }
    }

}
