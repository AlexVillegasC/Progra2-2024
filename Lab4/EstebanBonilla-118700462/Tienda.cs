using Lab4.WaynerDíaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.EstebanBonilla_118700462;
public class ContenedorZapateria
{
    private List<Camisa> public class ContenedorZapateria
    {
        private List<Zapato> _zapatos;
        private List<Comprador> _compradores;

        public ContenedorZapateria()
        {
            _zapatos = new List<Zapato>();
            _compradores = new List<Comprador>();
        }


        public void AgregarZapato(Zapato zapato)
        {
            _zapatos.Add(zapato);
        }

        public void AgregarCliente(Comprador compradores)
        {
            _compradores.Add(compradores);
        }

        public void MostrarZapatos()
        {
            Console.WriteLine("Zapatos disponibles en la Tienda:");
            foreach (var zapato in _zapatos)
            {
                Console.WriteLine($"Marca: {zapato.Marca}, Modelo: {zapato.Modelo}");
            }
        }

        public void MostrarClientes()
        {
            Console.WriteLine("Compradores registrados en la zapatería:");
            foreach (var cliente in _compradores)
            {
                Console.WriteLine($"Nombre: {comprador.Nombre}, Email: {comprador.Email}");
            }
        }

        public override string ToString()
        {
            return "ContenedorZapateria";
        }
    };
    private List<Comprador> _compradores;

    public ContenedorZapateria()
    {
        _zapatos = new List<Camisa>();
        _compradores = new List<Comprador>();
    }


    public void AgregarZapato(Camisa zapato)
    {
        _zapatos.Add(zapato);
    }

    public void AgregarCliente(Comprador compradores)
    {
        _compradores.Add(compradores);
    }

    public void MostrarZapatos()
    {
        Console.WriteLine("Zapatos disponibles en la Tienda:");
        foreach (var zapato in _zapatos)
        {
            Console.WriteLine($"Marca: {zapato.Marca}, Modelo: {zapato.Modelo}");
        }
    }

    public void MostrarClientes()
    {
        Console.WriteLine("Compradores registrados en la zapatería:");
        foreach (var cliente in _compradores)
        {
            Console.WriteLine($"Nombre: {comprador.Nombre}, Email: {comprador.Email}");
        }
    }

    public override string ToString()
    {
        return "ContenedorZapateria";
    }
}