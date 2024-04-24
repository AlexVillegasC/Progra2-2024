namespace Lab4.MariaGonzalez;

public class ContenedorTiendaCelulares
{
    private List<Celular> _celulares;
    private List<Cliente> _clientes;

    public ContenedorTiendaCelulares()
    {
        _celulares = new List<Celular>();
        _clientes = new List<Cliente>();
    }

    public void AgregarCelular(Celular celular)
    {
        _celulares.Add(celular);
    }

    public void AgregarCliente(Cliente cliente)
    {
        _clientes.Add(cliente);
    }

    public void MostrarCelulares()
    {
        Console.WriteLine("Celulares disponibles en la tienda:");
        foreach (var celular in _celulares)
        {
            Console.WriteLine($"Marca: {celular.Marca}, Modelo: {celular.Modelo}, Precio: {celular.Precio:C}");
        }
    }

    public void MostrarClientes()
    {
        Console.WriteLine("Clientes registrados en la tienda:");
        foreach (var cliente in _clientes)
        {
            Console.WriteLine($"Nombre: {cliente.Nombre}, Email: {cliente.Email}");
        }
    }
    public override string ToString()
    {
        string celularInfo = "Celulares disponibles en la tienda:\n";
        foreach (var celular in _celulares)
        {
            celularInfo += $"Marca: {celular.Marca}, Modelo: {celular.Modelo}, Precio: {celular.Precio:C}\n";
        }

        string clienteInfo = "Clientes registrados en la tienda:\n";
        foreach (var cliente in _clientes)
        {
            clienteInfo += $"Nombre: {cliente.Nombre}, Email: {cliente.Email}\n";
        }

        return celularInfo + clienteInfo;
    }
}
