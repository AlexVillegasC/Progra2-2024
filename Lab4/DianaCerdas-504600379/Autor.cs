namespace Lab4.DianaCerdas_504600379;

public class Autor
{
    public string Nombre { get; set; }

    public Autor(string nombre)
    {
        this.Nombre = nombre;
    }
    public override string ToString()
    {
        return $"Name: {Nombre}";
    }
}
