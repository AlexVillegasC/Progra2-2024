namespace Lab4.KarinaMoreno_504520784.Decoration;

public class Figures
{
    public string Nombre { get; set; }

    public Figures(string nombre)
    {
        this.Nombre = nombre;
    }

    public override string ToString()
    {
        return $"Name: {Nombre}";
    }
}