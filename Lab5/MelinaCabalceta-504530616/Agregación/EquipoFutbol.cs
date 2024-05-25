using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.MelinaCabalceta_504530616.Agregación
{
    public class EquipoFutbol
    {
        public List<Jugador> Jugadores { get; set; }

        public EquipoFutbol()
        {
            Jugadores = new List<Jugador>();
        }

        public void AgregarJugador(Jugador jugadores)
        {
            Jugadores.Add(jugadores);

        }

        public void MostrarJugador(Jugador jugadores)
        {
            Console.WriteLine("Jugadores del equipo: ");

            foreach (var jugador in Jugadores)
            {
                Console.WriteLine($"Nombre: {jugador.Nombre}, Numero: {jugador.Numero}");
            }
        }
    }
}

/*public class  Program
{
    public static void Main(string[] args) 
    {
        Jugador jugador1 = new Jugador("Cristiano Ronaldo", 7);
        Jugador jugador2 = new Jugador("Neymar Jr", 10);
        

        Equipofutbol equipofutbol = new Equipofutbol();
        equipofutbol.AgregarJugador(jugador1);
        equipofutbol.AgregarJugador(jugador2);
        
        equipofutbol.MostrarJugador(jugador1);

    }

}*/
