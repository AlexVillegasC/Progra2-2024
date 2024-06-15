
namespace Lab5.CristhianAltamirano_504570779.Agregacion;

public class Tienda
{
    public List<Clientes> Clientes { get; set; }

    public List<Productos> Productos { get; set; }

    public Tienda()
    {
        Clientes = new List<Clientes>();
        Productos = new List<Productos>();
    }

    public void AgregarCliente(Clientes cliente)
    {
        Clientes.Add(cliente);
    }

    public void AgregarProducto(Productos producto)
    {
        Productos.Add(producto);
    }

    /* Compilacion del codigo
     
        using Lab5.CristhianAltamirano_504570779.Agregacion;

        public class Program
        {
            public static void Main(string[] args)
            {
                Clientes cliente = new Clientes("Cristhian", "Altamirano" ,18, 504570779);
                Productos producto1 = new Productos("Cafe", 1800, 1);
                Productos producto2 = new Productos("Arroz", 3600, 2);
                Productos producto3 = new Productos("Frijoles", 2400, 3);
                Productos producto4 = new Productos("Azucar", 2700, 4);

                Tienda tienda = new Tienda();
                tienda.AgregarCliente(cliente);
                tienda.AgregarProducto(producto1);
                tienda.AgregarProducto(producto2);
                tienda.AgregarProducto(producto3);
                tienda.AgregarProducto(producto4);

            }
        }
      
     
     */
}
