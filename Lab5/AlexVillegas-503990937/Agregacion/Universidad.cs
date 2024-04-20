namespace Lab5.AlexVillegas_503990937.Agregacion;
]//sssss
public class Universidad
{
    public List<Estudiante> Estudiantes { get; set; }

    public Universidad()
    {
        Estudiantes = new List<Estudiante>();
    }

    public void AgregarEstudiante(Estudiante estudiante)
    {
        Estudiantes.Add(estudiante);
    }
}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Estudiante estudiante1 = new Estudiante("Juan Pérez", 20);
//        Estudiante estudiante2 = new Estudiante("María López", 22);

//        Universidad universidad = new Universidad();
//        universidad.AgregarEstudiante(estudiante1);
//        universidad.AgregarEstudiante(estudiante2);
//    }
//}
