using System;


namespace Lab4.BaironFallas_118860753.Producto;

public class Avion
{
    //atributos
    public string Name { get; private set; }
    public Avion(string name)
    {
        this.Name = name;  
    }

    public override string ToString()
    {
        return $"Name: {Name}";
    }

}
