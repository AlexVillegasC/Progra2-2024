namespace Lab3.BrendaEspinoza;

public class Animal : ITipoTerrestre, ITipoAcuatico, ITipoAereo
{

    public string Raza { get; set; }

    public string Color { get; set; }

    public string Sonido { get; set; }

    protected Animal(string raza, string color, string sonido)
    {
        this.Raza = raza;
        this.Color = color;
        this.Sonido = sonido;
    }

    public void Caminar()
    {

        throw new NotImplementedException();

    }
    public void Nadar()
    {

        throw new NotImplementedException();

    }

    public void Volar()
    {

        throw new NotImplementedException();

    }

}
