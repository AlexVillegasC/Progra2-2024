using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4.JasonReyes.Productos;

public class Celulares
{
    string Modelo { get; set; }
    string Marca { get; set; }

    public Celulares(string modelo, string marca)
    {
        this.Modelo = modelo;
        this.Marca = marca;
    }

    public override string ToString()
    {
        return $"Modelo: {Modelo}, Marca{Marca}";
    }

}
