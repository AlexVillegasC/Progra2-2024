namespace Lab3.DiegoGutierrez_504560809
{
    public class Swampert : ITipoAgua, ITipoTierra
    {
        public string Nombre { get; set; }

        public int Vida { get; set; }

        public int Ataque { get; set; }

        public Swampert(string nombre, int vida, int ataque) 
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Ataque = ataque;
        }

        public void AtaqueTipoAgua()
        {
            Console.WriteLine("Swampert ha utilizado Cascada!");
        }

        public void AtaqueTipoTierra()
        {
            Console.WriteLine("Swampert ha utilizado Terremoto!");
        }
    }
}
