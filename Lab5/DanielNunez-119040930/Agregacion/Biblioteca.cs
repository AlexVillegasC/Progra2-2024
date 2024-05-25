
namespace Lab5.DanielNunez_119040930.Agregacion;

public class Biblioteca
{
    public List<Libros> Libros { get; set; }

    public Biblioteca()
    {
        Libros = new List<Libros>();
    }

    public void AgregarLibro(Libros libros)
    {
        Libros.Add(libros);
    }
}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Libros libro1 = new Libros("Alcia en el país de las maravillas", 1865);
//        Libros libro2 = new Libros("El bossón de Higgs no te va a hacer la cama", 2016);

//        Biblioteca bliblioteca = new Biblioteca();
//        biblioteca.AgregarLibro(libro1);
//        biblioteca.AgregarLibro(libro2);
//    }
//}
