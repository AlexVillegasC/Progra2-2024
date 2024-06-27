using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.EstebanBonilla_118700462.Negocios
{
    public class Heladeria
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Tamanio { set; get; }


        public string Sabor { set; get; }


        public Heladeria(int id, string nombre, string tamanio, string sabor)
        {
            Id = id;
            Nombre = nombre;
            Tamanio = tamanio;
            Sabor = sabor;
        }
    }
}
