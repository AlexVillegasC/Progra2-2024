using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.AndreyEspinoza_116910175.Agregación
{
    public class Order
    {
        public int Id { get; set; }

        public List<Product> products { get; set; }
        public Order(int orderID) 
        {
            Id = orderID;
            products = new List<Product>();
        }

        public void Addorder (Product product)
        {
            products.Add(product);
        }

        public double CalculateTotal()
        {
            double Total = 0;
            foreach (var product in products) 
            {
                Total += product.price;
            }

            return Total;


        }
    }
}
