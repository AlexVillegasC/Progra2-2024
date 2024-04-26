namespace Lab5.JohanaAguero;

class Museo
{
    public string Nombre { get; set; }
    public List<Artículo> Colección { get; set; }

    public Museo(string nombre)
    {
        Nombre = nombre;
        Colección = new List<Artículo>();
    }

    public void AgregarArtículo(Artículo artículo)
    {
        Colección.Add(artículo);
    }
}
