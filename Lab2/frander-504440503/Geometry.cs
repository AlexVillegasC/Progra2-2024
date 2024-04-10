using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab2.frander_504440503;

public abstract class Geometry
{

    public string Formas { get; set; }

    protected Geometry(string formas)
    {
        this.Formas = formas;
    }

    public abstract void figura();

    public virtual void descripcion()
    {
        Console.WriteLine("esto es una forma Geometrica");
    }

}