namespace Lab4.WaynerDíaz;
public class ContenedorZapateria
{
    private List<Camisa> _zapatos;
    private List<Cliente> _clientes;

    public ContenedorZapateria()
    {
        _zapatos = new List<Camisa>();
        _clientes = new List<Cliente>();
    }


    public void AgregarZapato(Camisa zapato)
    {
        _zapatos.Add(zapato);
    }

    public void AgregarCliente(Cliente cliente)
    {
        _clientes.Add(cliente);
    }

    public void MostrarZapatos()
    {
        Console.WriteLine("Zapatos disponibles en la zapatería:");
        foreach (var zapato in _zapatos)
        {
            Console.WriteLine($"Marca: {zapato.Marca}, Modelo: {zapato.Modelo}");
        }
    }

    public void MostrarClientes()
    {
        Console.WriteLine("Clientes registrados en la zapatería:");
        foreach (var cliente in _clientes)
        {
            Console.WriteLine($"Nombre: {cliente.Nombre}, Email: {cliente.Email}");
        }
    }

    public override string ToString()
    {
        return "ContenedorZapateria";
    }
}