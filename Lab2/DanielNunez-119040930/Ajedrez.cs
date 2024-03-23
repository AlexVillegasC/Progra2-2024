using System;

namespace Lab2.DanielNunez_119040930;

public abstract class Ajedrez
{
    public string Movimiento {  get; set; }
    protected Ajedrez(string movimiento)
    {
        this.Movimiento = movimiento;
    }
    public abstract void Mover();

    public virtual void JugadaGanadora()
    {
        Console.WriteLine("Jaque mate");
    }
}
