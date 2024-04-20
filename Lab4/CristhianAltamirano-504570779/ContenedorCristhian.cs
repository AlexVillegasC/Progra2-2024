using Lab4.CristhianAltamirano_504570779.Vehiculoss;

namespace Lab4.CristhianAltamirano_504570779;

public class ContenedorCristhian<T>
{
    private List<T> elementos = new List<T>(); // Lista para almacenar elementos de cualquier tipo

    // Método para agregar elementos al contenedor
    public void Agregar(T elemento)
    {
        elementos.Add(elemento);
    }

    // Método para mostrar los elementos del contenedor
    public void MostrarElementos()
    {
        Console.WriteLine("Vehiculos en el contenedor:");
        foreach (var elemento in elementos)
        {
            Console.WriteLine(elemento);
        }
    }

    internal void Agregar(Motoss moto)
    {
        throw new NotImplementedException();
    }

    internal void Agregar(object moto)
    {
        throw new NotImplementedException();
    }

    //public static implicit operator ContenedorCristhian<T>(Vehiculos.ContenedorCristhian<Carro> v)
    //{
    //    throw new NotImplementedException();
    //}
}
