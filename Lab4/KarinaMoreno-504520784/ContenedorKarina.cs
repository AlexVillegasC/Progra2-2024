namespace Lab4.KarinaMoreno_504520784;

public class ContenedorKarina<T>
{
    private List<T> objetos = new List<T>();

    public void agregar(T objeto)
    {
        objetos.Add(objeto);
    }

    public void mostrarObjetos()
    {
        Console.WriteLine("Objetos en el contenedor: ");
        foreach (T objeto in objetos)
        {
            Console.WriteLine($"{objeto}");
        }
    }
}

// CODIGO para el ejecutar en el Program.cs
//using Lab4.KarinaMoreno_504520784;
//using Lab4.KarinaMoreno_504520784.Decoration;

//ContenedorKarina<Plushies> HomeDecor = new Lab4.KarinaMoreno_504520784.ContenedorKarina<Plushies>();
//Plushies cinnamoroll = new Plushies("cinnamoroll");
//HomeDecor.agregar(cinnamoroll);
//HomeDecor.mostrarObjetos();