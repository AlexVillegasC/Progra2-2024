using Lab1.Bairon_fallas;
using System;
using System.ComponentModel.Design;

namespace Lab1.Bairon_fallas
{
    public class Batalla
    {
        public void Pelear(Pokemon pikachu, Pokemon gengar)
        {
            while (pikachu.Vida > 0 && gengar.Vida >0)
            {
                // Turno de pikachu
                gengar.Vida -= pikachu.Ataque;
                if (gengar.Vida <= 0)
                {
                    Console.WriteLine($"gengar ha sido derrotado!");
                    Console.WriteLine($"pikachu es el ganador!");
                   
                    return;
                }
                Console.WriteLine($" pikachu ataca a gengar, Vida de gengar despues del ataque: {gengar.Vida}");



                // Turno de gengar
                pikachu.Vida -= gengar.Ataque;
                // Verificar si pikachu ha sido derrotado
                if (pikachu.Vida <= 0)
                {
                    Console.WriteLine($"pikachu ha sido derrotado!");
                    Console.WriteLine($"gengar es el ganador!");
                    return;
                }
                Console.WriteLine($" Gengar ataca a pikachu, Vida de pikachu despues del ataque: {pikachu.Vida}");
                
            }
        }
    }
}

/*
 * que quiere?
 * 
 * 
 * */


//using Lab2.BaironFallas_118860753;

//Circulo circulo = new Circulo("circulo", 90);