using System;
namespace Lab5.BrendaEspinoza_702770802.Composicion;


public class Casa
{
    public Habitacion Habitacion { get; private set; }

    public Casa()
    {
        Habitacion = new Habitacion();

    }
    public void MostrarHabitacion()
    {
        Console.WriteLine(Habitacion.Color);
    }
}

/*namespace Lab5.BrendaEspinoza_702770802.Composicion;

public class Program
    {
        public static void Main(string[] args)
        {
            // Crear instancia de Casa
            Casa miCasa = new Casa();

            // Mostrar el color de la habitación
            miCasa.MostrarHabitacion();
        }
}*/
//