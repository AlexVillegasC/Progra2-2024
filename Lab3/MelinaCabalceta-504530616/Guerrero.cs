using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.MelinaCabalceta_504530616
{
    public class Guerrero
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public string Armadura { get; set; }

        protected Guerrero(string nombre, int nivel, string armadra)
        {
            Nombre = nombre;
            Nivel = nivel;
            Armadura = armadra;
        }
    }
}
