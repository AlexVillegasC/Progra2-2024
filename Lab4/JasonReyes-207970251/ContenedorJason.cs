using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.JasonReyes;

public class ContenedorJason<T>
{
    private List<T> elements = new List<T>();

    //Agregar
    public void Agregar(T elemento)
    {
        elements.Add(elemento);
    }

  
    
    
    
    //Mostrar todos los elementos del contenedor
    public void MostrarElementos()
    {
        Console.WriteLine("Elementos en el contenedor:");
        foreach (var elemento in elements)
        {
            Console.WriteLine(elemento);
        }
    }

   
    public void MostrarOne(string modelo)
    {
        foreach (var elemento in elements)
        {
            
            if (elemento != null && elemento.ToString() == modelo)
            {
                Console.WriteLine(elemento);
                break;
            }
        }
    }

}
