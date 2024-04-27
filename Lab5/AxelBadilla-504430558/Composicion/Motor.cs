
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.AxelBadilla_504430558.Composicion
{
    public class Motor
    {

        public string Arrancar { set; get; }

        public string Apagar { set; get; }

        public Motor()
        {
            Arrancar = "El carro arranca para avanzar";

            Apagar = "El carro se apaga porque no se va a utilizar";

        }
    }
}