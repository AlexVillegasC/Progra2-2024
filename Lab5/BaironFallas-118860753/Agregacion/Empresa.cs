using System;


namespace Lab5.BaironFallas_118860753.Agregacion;

public class Empresa
{
    public List<Proyectos> listProyectos = new List<Proyectos>();

    public Empresa()
    {
        listProyectos = new List<Proyectos>();
    }

    public void Agregar(Proyectos proyecto)
    {
        listProyectos.Add(proyecto);
    }
    public void Imprimir()
    {
        foreach(var x in listProyectos)
        {
            Console.WriteLine($"Nombre del proyecto: {x.Nombre}");
            Console.WriteLine($"Descripcion del proyecto: {x.Descripcion}");
        }
    }
}
