
namespace lab4.JohanaAguero;

public class ContenedorBiblioteca
{
    private List<Libro> libros = new List<Libro>();
    private List<Persona> visitantes = new List<Persona>();

    //public void AgregarLibro(Libro libro)
    //{
    //    libros.Add(libro);
    //}

    //public void AgregarVisitante(Persona persona)
    //{
    //    visitantes.Add(persona);
    //}
     
    //public void MostrarLibros()
    //{
    //    Console.WriteLine("Libros en la biblioteca:");
    //    foreach (var libro in libros)
    //    {
    //        libro.MostrarDetalles();
    //    }
    //}

    //public void MostrarVisitantes()
    //{
    //    Console.WriteLine("Visitantes en la biblioteca:");
    //    foreach (var persona in visitantes)
    //    {
    //        persona.MostrarInformacion();
    //    }
    //}

    public override string ToString()
    {
        string librosStr = "Libros en la biblioteca:\n";
        foreach (var libro in libros)
        {
            librosStr += libro.ToString() + "\n";
        }

        string visitantesStr = "Visitantes en la biblioteca:\n";
        foreach (var persona in visitantes)
        {
            visitantesStr += persona.ToString() + "\n";
        }

        return librosStr + visitantesStr;
    }
}