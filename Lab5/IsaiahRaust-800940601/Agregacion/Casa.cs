namespace Lab5.IsaiahRaust_800940601.Agregacion;


public class Casa
{
    public List<Persona> Persona { get; set; }

    public Casa()
    {
        Persona = new List<Persona>();
    }

    public void AgregarEstudiante(Persona persona)
    {
        Persona.Add(persona);
    }
}