namespace Lab4.KarinaMoreno_504520784.Decoration;

public class Plushies
{
    public string Nombre { get; set; }

    public Plushies(string nombre)
    {
        this.Nombre = nombre;
    }

    public override string ToString()
    {
        return $"Name: {Nombre}";
    }
}