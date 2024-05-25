using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.AxelZuniga_504250653.composicion
{
    public class Procesador
    {
        public string gama {  get; set; }
        public int precio { get; set; }


        public Procesador(string gama,int precio)
        {
            this.gama = gama;
            this.precio = precio;

        }


    }
}
