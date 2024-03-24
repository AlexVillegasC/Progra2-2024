namespace Lab2.MariaGonzalez
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Laptop laptop = new Laptop("Inspiron", 800, "Dell");
            Desktop desktop = new Desktop("OptiPlex", 1200, "HP");

            Console.WriteLine("Estado de las computadoras:");
            laptop.Encender();
            laptop.Apagar();
            Console.WriteLine(laptop);

            desktop.Encender();
            desktop.Apagar();
            Console.WriteLine(desktop);
        }
    }
}
