

namespace Lab4.ArianaHernandez_504520730.Frutas
{
    public class Fruta
    {
        public string Name { get; set; }

        public Fruta(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }

}
