using System;

namespace Lab3.AlondraFlores
{
    class Program
    {
        static void Main(string[] args)
        {
            Militar militar = new Militar("Hola", 23);

            militar.Disparar();
            militar.Lanzar();
        }
    }
}