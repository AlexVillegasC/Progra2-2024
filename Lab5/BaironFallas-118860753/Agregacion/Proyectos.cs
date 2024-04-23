using System;


namespace Lab5.BaironFallas_118860753.Agregacion;

public class Proyectos
{
    public string Nombre { get; set; }

    public string  Descripcion { get; set; }

    public Proyectos(string nombre , string descripcion)
    {
        Nombre = nombre;
        Descripcion = descripcion;
    }
}
//codigo para program
/*
using Lab5.BaironFallas_118860753.Agregacion;
using Lab5.BaironFallas_118860753.Composicion;

Avion avion = new Avion();
Console.WriteLine($"Potencia del motor: {avion.Motor.Potencia}");
Console.WriteLine($"Sistema de la puntas de las alas: {avion.Alas.SistemaDePuntasAla}");


Empresa empresa = new Empresa();
Proyectos proyectos = new Proyectos("Segunda guerra mundial","Crear un resumen");
empresa.listProyectos.Add(proyectos);
empresa.Imprimir();
*/