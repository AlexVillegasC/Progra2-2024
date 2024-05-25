using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.AxelZuniga_504250653.composicion
{
    public class PcEscritorio
    {
        public Procesador Procesador { get; private set; }


        public PcEscritorio()
        {
            Procesador =new Procesador("alta",50);

        }

    }
}
