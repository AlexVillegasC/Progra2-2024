using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.JhonnRojas_703090697.Empresa
{
    public class Zapateria
    {
        public string Marca_calzado { get; set; }

        public int Talla { get; set;}

        public string Color { get; set;}
     
        
        public Zapateria(string marca_calzado, int talla,string color)
        {
            Marca_calzado= marca_calzado;
            Talla = talla;
            Color = color;
        }

    }
}
