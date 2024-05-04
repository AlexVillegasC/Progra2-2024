namespace Lab5.DiegoGutierrez_504560809.Agregacion
{
    public class Pokemon
    {
        public int Vida { get; set; }

        public int Ataque { get; set; }

        public string Nombre { get; set; }

        public Pokemon(int ataque, int vida, string nombre)
        {
            this.Ataque = ataque;
            this.Vida = vida;
            this.Nombre = nombre;

        }
    }
}
