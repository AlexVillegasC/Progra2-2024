using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.MelinaCabalceta_504530616.Agregación
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }

        public Jugador(string nombre, int numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
