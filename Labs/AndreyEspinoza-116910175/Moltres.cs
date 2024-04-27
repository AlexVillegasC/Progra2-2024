

namespace Lab1.AndreyEspinoza_116910175
{
    public class Moltres : Pokemon
    {
        public Moltres(int vida, int ataque, string name) : base (vida, ataque, name)
    
        { }

        public int Vida {  get; internal set; }
        
        public int Ataque { get; internal set; }

        public static implicit operator Moltres(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
