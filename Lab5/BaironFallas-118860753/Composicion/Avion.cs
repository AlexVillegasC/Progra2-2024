using System;


namespace Lab5.BaironFallas_118860753.Composicion;

public class Avion
{
    public Motor Motor { get; private set; }
    public Alas Alas { get; private set; }

    public Avion()
    {
        Motor = new Motor();
        Alas = new Alas();
    }

}
