namespace Lab4.AlondraFlores_504590983.Alimentos;

public class Combos
{
    public string NombreCombo { get; set; }

    public Combos(string nombre)
    {
        this.NombreCombo = nombre;
    }

    public override string ToString()
    {
        return $"NCombos: {NombreCombo}";
    }
}

