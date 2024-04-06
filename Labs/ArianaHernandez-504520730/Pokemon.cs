namespace Lab1.ArianaHernandez;
using System;

public class Pokemon
{
    public string Nombre { get; set; }
    public int PuntosDeVida { get; set; }
    public int Ataque { get; set; }

    public Pokemon(int ataque, int puntosDeVida, string nombre)
    {
        Nombre = nombre;
        PuntosDeVida = puntosDeVida;
        Ataque = ataque;
    }
}
