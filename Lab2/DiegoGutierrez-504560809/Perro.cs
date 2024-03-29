namespace Lab2.DiegoGutierrez_504560809
{
    public class Perro : Animal
    {
        public Perro(string nombre, int peso, string habitat) : base(nombre, peso, habitat) 
        {

        }

        public override void Accion()
        {
            Console.WriteLine("Estoy ladrando");
        }

        public override void QueSoy()
        {
            Console.WriteLine("Soy un perro");
        }
    }
}
