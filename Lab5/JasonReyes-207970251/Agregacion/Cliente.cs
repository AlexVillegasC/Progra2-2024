using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.JasonReyes.Agregacion;

public class Cliente
{
    public string Nombre {  get; set; }
    public int Identificacion { get; set; }


    public Cliente(string nombre, int identificacion)
    {
        this.Nombre = nombre;
        this.Identificacion = identificacion;
    }


}
