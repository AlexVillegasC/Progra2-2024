
using Lab5.BrandonNunez_305370647.Composicion;

namespace Lab5.BrandonNunez_305370647.Composicion
{
    public class Orden
    {
        private List<Producto> productos;

        public Orden()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)  // Método para agregar un Producto a la Orden
        {
            productos.Add(producto);
        }
       
        public double CalcularTotal()  
        {
            double total = 0;
            foreach (Producto producto in productos)
            {
                total += producto.Precio;
            }
            return total;
        }

        public void ImprimirOrden()    // imprimir los detalles de la Orden
        {
            Console.WriteLine("Detalles de la orden:");
            foreach (Producto producto in productos)
            {
                Console.WriteLine($"Producto: {producto.Nombre}, Precio: {producto.Precio}");
            }
            Console.WriteLine($"Total de la orden: {CalcularTotal()}");
        }
    }
}

//using lab5.brandonnunez_305370647.Composicion;
//public class program
//{
//    public static void Main(string[] args)
//    {
//        Orden nuevaorden = new Orden();
//        Console.WriteLine($"Lista: {nuevaorden.ImprimirOrden}");
//    }
//}
