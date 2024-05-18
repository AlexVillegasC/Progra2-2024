namespace Lab5.AndreyEspinoza_116910175.Agregación
{
    public class Product 
    {
        public string name {  get; set; }
        public double price { get; set; }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
