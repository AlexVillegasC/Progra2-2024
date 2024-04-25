using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.JasonReyes.Composicion;

public class TV
{
    public string Modelo { get; private set; }
    public string Marca { get; private set; }

    public TV(string modelo, string marca)
    {
        Modelo = modelo;
        Marca = marca;
    }





}
