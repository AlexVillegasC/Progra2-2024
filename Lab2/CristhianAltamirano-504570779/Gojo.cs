
namespace Lab2.CristhianAltamirano;
    public class Gojo : Jujutsu
    {
        public Gojo(int ataque, int vida, string Nombre, int dominio) : base(ataque, vida, Nombre, dominio)
        {
        }

        public override void ExpansionDeDominio()
        {
            Console.WriteLine("Azul");
            Console.WriteLine("Rojo");
            Console.WriteLine("Ritual de vacio.... Purpura.");
            Console.WriteLine("Nah, i'd win!");
        }
    }

