﻿namespace Lab1.Danny_Abarca_504000385
{
    internal class Pokemon
    {

        public int Ataque { get; set; }

        public int Vida { get; set; }

        public int Defensa { get; set; }
        public string Nombre { get; set; }

        public Pokemon(int ataque, int vida, int defensa, string Nombre)
        {
            this.Vida = vida;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Nombre = Nombre;
        }

    }
}
