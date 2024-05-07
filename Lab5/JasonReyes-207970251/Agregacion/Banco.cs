using Lab5.AlexVillegas_503990937.Agregacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.JasonReyes.Agregacion;

public class Banco
{
    public List<Cliente> Clientes { get; set; }

    public Banco()
    {
        Clientes = new List<Cliente>();
    }

    public void AgregarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    public void MostrarClientes()
    {
        foreach (Cliente cliente in Clientes)
        {
            Console.WriteLine($"Nombre: {cliente.Nombre}," +
                $" Identificación: {cliente.Identificacion}");
        }
    }


}
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Cliente cliente1 = new Cliente("Pedro Ruiz", 23);
//        Cliente cliente2 = new Cliente("Nayeli Blanco", 24);

//        Banco banco = new Banco();
//        banco.AgregarCliente(cliente1);
//        banco.AgregarCliente(cliente2);

//        banco.MostrarClientes();
//    }
//}