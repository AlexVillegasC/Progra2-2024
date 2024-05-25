using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.JasonReyes;

public class Goku : ISuperAtaque, ISuperDefensa
{

    public int Nivel { get; set; } //Nivel de pelea
    public int Vida { get; set; }
    public bool PoderEspecialDisponible { get; set; }

    protected Goku(int nivel, int vida, bool poderEspecialDisponible)
    {
        this.Nivel = nivel;
        this.Vida = vida;
        this.Equals(poderEspecialDisponible);
    }


    public void Kamehameha()
    {
        Console.WriteLine("Enemigo eliminado");
    }

    public void Teletransportacion()
    {
        Console.WriteLine("Goku esquiva al enemigo");
    }
}
