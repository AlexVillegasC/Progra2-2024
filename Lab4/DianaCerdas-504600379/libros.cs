namespace Lab4.DianaCerdas_504600379;

public class Libros
{
    public string Nombre { get; set; }

    public Libros(string nombre)
    {
        this.Nombre = nombre;
    }
    public override string ToString()
    {
        return $"Name: {Nombre}";
    }
}