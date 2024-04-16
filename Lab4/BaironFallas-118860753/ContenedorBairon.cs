using System;


namespace Lab4.BaironFallas_118860753;

public class ContenedorBairon<T>
{
    //creacion de la lista la generica
    private List<T> ListaElementos = new List<T>();

    //metodo de agregar 
    public void Agregar(T elemento)
    {
        ListaElementos.Add(elemento);
    }
    //imprimir
    public void Imprimir()
    {
        Console.WriteLine("Elementos en el contenedor:");
        foreach (var x in ListaElementos)
        {
            Console.WriteLine(x);
        }
    }
}

//codigo para program
/*
 * using Lab4.BaironFallas_118860753;
using Lab4.BaironFallas_118860753.Producto;

ContenedorBairon<Avion> contenedorBairon = new ContenedorBairon<Avion>();
Avion avionMilitar = new Avion("Avion militar");
Avion avionComercial = new Avion("Avion comercial");
contenedorBairon.Agregar(avionMilitar);
contenedorBairon.Agregar(avionComercial);
contenedorBairon.Imprimir();
*/