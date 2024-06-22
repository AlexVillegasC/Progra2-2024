using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.EstebanBonilla_118700462.Negocios;

    public class VentaCamisas
{
    public string Marca_Camisas { get; set; }

    public int Talla { get; set; }

    public string Color { get; set; }


    public VentaCamisas(string marca_camisas, int talla, string color)
    {
        Marca_Camisas = marca_camisas;
        Talla = talla;
        Color = color;
    }

}

