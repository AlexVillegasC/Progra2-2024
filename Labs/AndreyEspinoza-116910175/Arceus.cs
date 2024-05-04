

namespace Lab1.AndreyEspinoza_116910175
{
    public class Arceus : Pokemon
    {
        public Arceus(int vida, int ataque, string name) : base (vida, ataque, name)
        { }

        public int Vida {  get; internal set; }
        public int ataque { get; internal set; }
    }
}
