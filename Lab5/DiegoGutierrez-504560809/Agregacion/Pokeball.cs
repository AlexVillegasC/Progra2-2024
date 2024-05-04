namespace Lab5.DiegoGutierrez_504560809.Agregacion
{
    public class Pokeball
    {
        public List<Pokemon> Pokemons { get; set; }

        public Pokeball()
        {
            Pokemons = new List<Pokemon>();
        }

        public void AddPokemons(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }
    }

    /*public class Program
    {
        public static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon(321, 400, "Swampert");
            Pokemon pokemon2 = new Pokemon(300, 350, "Greninja");
            Pokemon pokemon3 = new Pokemon(238, 280, "Pikachu");

            Pokeball pokeball = new Pokeball();
            pokeball.AddPokemons(pokemon1);
            pokeball.AddPokemons(pokemon2);
            pokeball.AddPokemons(pokemon3);
        }
    }*/
}
