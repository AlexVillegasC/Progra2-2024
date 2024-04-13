using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.MelinaCabalceta_504530616
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }


        public Producto(string nombre, string marca)
        {
            this.Nombre = nombre;
            this.Marca = marca;
        }

        public override string ToString()
        {
            return $"{Nombre} marca {Marca}";
        }

    }
}

