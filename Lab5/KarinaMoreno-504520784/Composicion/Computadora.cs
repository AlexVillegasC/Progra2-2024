namespace Lab5.KarinaMoreno_504520784.Composicion;

public class Computadora
{
    public Procesador Procesador { get; private set; }

    public Computadora()
    {
        Procesador = new Procesador();
    }
}