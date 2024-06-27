using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.EstebanBonilla_118700462.Agregacion;
public class Autobus
{
    List<Viajero> Viajeros = new List<Viajero>();

    public void AgregarViajero(Viajero viajero)
    {
        Viajeros.Add(viajero);
    }

    public void ImprimirViajeros()
    {
        foreach (var viajero in Viajeros)
        {
            Console.WriteLine($"Identificación: {viajero.Identificacion}\nNombre: {viajero.PrimerNombre}\nApellido: {viajero.PrimerApellido}");
        }
    }

    public void Menu()
    {
        int opcion;

        do
        {
            MostrarMenu();
            opcion = ObtenerOpcion();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Agrega un nuevo viajero:");
                    AgregarViajero(CrearViajero());
                    Console.WriteLine("El viajero se ha agregado con éxito:");
                    break;
                case 2:
                    Console.WriteLine("Datos del viajero:");
                    ImprimirViajeros();
                    break;
                case 0:
                    Console.WriteLine("Cerrando programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        } while (opcion != 0);
    }

    public void MostrarMenu()
    {
        Console.WriteLine("+++++++ Menú +++++++");
        Console.WriteLine("1. Agregar viajero");
        Console.WriteLine("2. Imprimir viajeros");
        Console.WriteLine("0. Cerrar programa");
    }

    public int ObtenerOpcion()
    {
        Console.WriteLine("Elige una opción:");
        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            return opcion;
        }
        else
        {
            Console.WriteLine("Esta opción no existe");
            return ObtenerOpcion();
        }
    }

    private Viajero CrearViajero()
    {
        Console.WriteLine("Ingrese la identificación del viajero:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el nombre del viajero:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el apellido del viajero:");
        string apellido = Console.ReadLine();

        return new Viajero(id, nombre, apellido);
    }
}
