﻿namespace Lab1.DanielNunez___119040930
{
    public class Charizard : Pokemon
    {
        public Charizard(int vida, int ataque, string nombre) : base(vida, ataque, nombre)
        {

        }

        public int Vida { get; internal set; }
        public int Ataque { get; internal set; }
    }

}
