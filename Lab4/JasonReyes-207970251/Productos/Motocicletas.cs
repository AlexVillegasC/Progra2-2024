using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.JasonReyes.Productos;

public class Motocicletas
{
    string Modelo { get; set; }
    string Marca { get; set; }

    public Motocicletas(string modelo, string marca)
    {
        this.Modelo = modelo;
        this.Marca = marca;
    }

    public override string ToString()
    {
        return $"Modelo: {Modelo}, Marca{Marca}";
    }

}
