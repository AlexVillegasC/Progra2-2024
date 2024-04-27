using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.EstebabBonilla_118700462;

    public class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }

    
    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        Año = DateTime.Now.Year; 
    }

    public Vehiculo(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}");
    }

    public void Arrancar()
    {
        Console.WriteLine("El vehículo ha encendido.");
    }

    public void Arrancar(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}

}