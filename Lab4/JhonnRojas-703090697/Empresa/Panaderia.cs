using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.JhonnRojas_703090697.Empresa
{
    public class Panaderia
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Tamanio{ set; get; }

        public string Forma { set; get; }

        public string Color { set; get; }


        public Panaderia(int id, string nombre, string tamanio, string forma, string color)
        {
            Id = id;
            Nombre = nombre;
            Tamanio = tamanio;
            Forma = forma;
            Color = color;
        }
    }
}
