

namespace Lab2.Bairon_fallas;

public abstract class FiguraGeometrica
{
    public string Name { get; set; }

    protected FiguraGeometrica(string name)
    {
        this.Name = name;
    }
    public abstract void CalcularArea();

    public abstract void CalcularPerimetro();





}
