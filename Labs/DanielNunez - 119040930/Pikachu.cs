namespace Lab1.DanielNunez___119040930
{
    public class Pikachu : Pokemon
    {
        // Constructor de la clase Pikachu que llama al constructor de la clase base (Pokemon)
        public Pikachu(int vida, int ataque, string nombre) : base(vida, ataque, nombre)
        {
            // No es necesario agregar más código aquí, ya que los atributos se inicializan en el constructor de la clase base
        }

        public int Vida { get; internal set; }
        public int Ataque { get; internal set; }
    }

}
