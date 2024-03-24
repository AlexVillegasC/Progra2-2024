namespace Lab2.MariaGonzalez
{
  
    public class Laptop : Computadora
    {
        private string marca;

        
        public Laptop(string modelo, int precio, string marca) : base(modelo, precio)
        {
            this.marca = marca;
        }

        
        public override void Encender()
        {
            Console.WriteLine($"La laptop {modelo} de marca {marca} está encendiendo...");
        }

        
    }
}
