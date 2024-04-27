namespace Lab5.JohanaAguero;

class Artículo
{
    public string Nombre { get; set; }
    public string Descripción { get; set; }

    public Artículo(string nombre, string descripción)
    {
        Nombre = nombre;
        Descripción = descripción;
    }
}
