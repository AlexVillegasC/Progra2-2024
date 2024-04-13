namespace Lab4.AlondraFlores_504590983.Alimentos;

public class Bebidas
{
    public string Nombre { get; set; }

    public Bebidas(string nombre)
    {
        this.Nombre = nombre;
    }

    public override string ToString()
    {
        return $"NBebida: {Nombre}";
    }
}

