using System;


namespace Lab3.BaironFallas_118860753;

public class Avion:IVolador,IAterrizaje
{
    //implementacion de los metodos
    public void Volar()
    {
        Console.WriteLine("El avion esta volando");
    }

    public void Aterrizar()
    {
        Console.WriteLine("El avion esta aterrizando");
    }
}

//codigo de prueba
/*
using Lab3.BaironFallas_118860753;

Pajaro pajaro = new Pajaro();
pajaro.Volar();
pajaro.Aterrizar();

Avion avion = new Avion();
avion.Volar();
avion.Aterrizar();
*/