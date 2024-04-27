using System;

namespace Lab3.BaironFallas_118860753;

public class Pajaro :IVolador,IAterrizaje
{
    public void Volar()
    {
        Console.WriteLine("El pajaro esta volando");
    }
    public void Aterrizar()
    {
        Console.WriteLine("El pajaro esta aterrizando");
    }
    
}

