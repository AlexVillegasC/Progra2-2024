namespace Lab4.Frander_504440503.Personas;

public class Persona
{

    public string nombre { get; set; }
    public int id { get; set; }

    Persona(string _nombre, int _id)
    {
        nombre = _nombre;
        id = _id;
    }

}