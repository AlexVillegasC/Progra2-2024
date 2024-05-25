using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.JasonReyes;

public class ContenedorJason<T>
{
    private List<T> elements = new List<T>();
//Metodo para agregar
    public void Agregar(T elemento) { 
        elements.Add(elemento);
    }

    //Metodo para mostrar los elementos
    public void MostrarElementos()
    {
        Console.WriteLine("Elementos en el contenedor:");
        foreach (var elemento in elements)
        {
            Console.WriteLine(elemento);
        }
    }
}
