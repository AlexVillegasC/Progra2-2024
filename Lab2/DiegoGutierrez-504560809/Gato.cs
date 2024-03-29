namespace Lab2.DiegoGutierrez_504560809
{
    public class Gato : Animal
    {
        public Gato(string nombre, int peso, string habitat) : base(nombre, peso, habitat) { }

        public override void Accion()
        {
            Console.WriteLine("Estoy maullando");
        }
        public override void QueSoy()
        {
            Console.WriteLine("Soy un Gato!");
        }
    }
}
