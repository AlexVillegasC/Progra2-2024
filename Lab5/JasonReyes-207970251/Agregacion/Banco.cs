using Lab5.CristhianAltamirano_504570779.Agregacion;
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

    //Agregar cliente
    public void AgregarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
    }
    


    //Mostrar clientes
    public void ImprimirClientes(Cliente cliente)
    {
        foreach(var Cliente in Clientes)
        {
            Console.WriteLine(cliente);
        }
    }

}
