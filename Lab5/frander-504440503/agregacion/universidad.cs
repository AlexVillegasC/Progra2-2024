namespace Lab5.frander_504440503.agregacion;

public class Universidad
{
    public List<Profesor> Profesores { get; set; }

    public Universidad()
    {
        Profesores = new List<Profesor>();
    }

    public void AgregarProfesor(Profesor profesor)
    {
        Profesores.Add(profesor);
    }
}

/*

        Profesor profesor1 = new Profesor("Dr. Smith", "Matemáticas");
        Profesor profesor2 = new Profesor("Dra. Johnson", "Física");

        Universidad universidad = new Universidad();
        universidad.AgregarProfesor(profesor1);
        universidad.AgregarProfesor(profesor2);
*/
