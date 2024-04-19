using System;

namespace Lab4.BaironFallas_118860753.Producto;

public class Herramienta
{
    //atributos
    public string Name { get; set; }

    public Herramienta(string name)
    {
        this.Name = name;
  
    }

    public override string ToString()
    {
        return $"NAME: {Name}";
    }

}
