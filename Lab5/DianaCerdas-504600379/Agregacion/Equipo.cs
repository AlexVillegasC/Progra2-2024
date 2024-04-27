

namespace Lab5.DianaCerdas_504600379.Agregacion
{
    public class Equipo
    {
      public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            Jugadores = new List<Jugador>();
        }

        public void AgregarJugador(Jugador jugador )
        {
            Jugadores.Add(jugador);
        }
    }
}


