namespace Lab4.Frander_504440503.Personas;

public class Persona
{

    public string nombre { get; set; }
    public int id { get; set; }

   public Persona(string _nombre, int _id)
    {
        nombre = _nombre;
        id = _id;
    }

    public override string ToString()
    {
        return $@"Nombre: {nombre}\n
        ID: {id}";
    }

}