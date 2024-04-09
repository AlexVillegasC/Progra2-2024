using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.MelinaCabalceta_504530616
{
    public class GuerreroHabilidoso : Guerrero, IArmaCuerpoACuerpo, IArmaADistancia
    {
        public GuerreroHabilidoso(string nombre, int nivel, string armadura) : base(nombre, nivel, armadura)
        {
        }

        public void AtacarConEspada()
        {
            Console.WriteLine($"{Nombre}  ataca con su espada");
        }

        public void DispararArco()
        {
            Console.WriteLine($"{Nombre} ataca con su arco" );
        }

        static void Main(string[] args)
        {
            //Crear una instancia de un guerrero habilidoso con nivel 10
            GuerreroHabilidoso guerrero = new GuerreroHabilidoso("Drako", 10, "Acero");

            guerrero.AtacarConEspada();
            guerrero.DispararArco();

            //Mostrar el nivel del guerrero y la armadura
            Console.WriteLine($" Nivel del guerrero:{guerrero.Nivel}");
            Console.WriteLine($" Armadura del guerrero:{guerrero.Armadura}");
        }
    }
}
