using System.Diagnostics.Contracts;
using Lab5.Frander_504440503.Agregacion;
namespace Lab5.Frander_504440503.composicion;

public class Computadora {

    public Procesador Procesador{get; private set;}
    public MemoriaRam MemoriaRam{get; private set;}

    public Computadora(Procesador procesador, MemoriaRam memoriaRam) { 
        
        this.Procesador = procesador;
        this.MemoriaRam = memoriaRam;
    }

}
/*
public class Program
{
    MemoriaRam memoria = new MemoriaRam(20);
    Procesador procesador = new Procesador("intel i7");

    Computadora computadora = new Computadora(procesador, memoria);

    Console.WriteLine($"Marca de Procesador: {computadora.Procesador.Marca}");
    Console.WriteLine($"Cantidad de Ram: {computadora.MemoriaRam.CantidadRam}");
}



*/